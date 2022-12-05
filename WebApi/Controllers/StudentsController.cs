using Domain.Models;
using Infastructure.Persistance.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentsController(IRepository<Student> repository)
        {
            _studentRepository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudents([FromQuery] int recordFrom, int recordTo)
        {
            if (recordFrom != 0 && recordTo != 0 && recordFrom > recordTo)
            {
                return BadRequest();
            }

            var students = _studentRepository.GetAll();
            
            if (recordTo == 0)
            {
                return Ok(students.Skip(recordFrom));
            }

            return Ok(students.Skip(recordFrom).Take(recordTo - recordFrom));
        }
    }
}
