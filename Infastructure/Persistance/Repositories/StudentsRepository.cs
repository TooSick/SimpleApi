using Domain.Models;
using Infastructure.Persistance.Interfaces;

namespace Infastructure.Persistance.Repositories
{
    public class StudentsRepository : IRepository<Student>
    {
        private List<Student> students;

        public StudentsRepository()
        {
            students = new List<Student>
            {
                new Student
                {
                    FirstName = "Святослав",
                    LastName = "Святославович",
                    GroupNumber = "123"
                },
                new Student
                {
                    FirstName = "Александр",
                    LastName = "Александрович",
                    GroupNumber = "123"
                },
                new Student
                {
                    FirstName = "Владислав",
                    LastName = "Павлович",
                    GroupNumber = "231"
                },
                new Student
                {
                    FirstName = "Дмитрий",
                    LastName = "Дмитриевич",
                    GroupNumber = "231"
                },
                new Student
                {
                    FirstName = "Денис",
                    LastName = "Алексеевич",
                    GroupNumber = "321"
                },
                new Student
                {
                    FirstName = "Светланна",
                    LastName = "Николевна",
                    GroupNumber = "321"
                },
                new Student
                {
                    FirstName = "Алексей",
                    LastName = "Алексеевич",
                    GroupNumber = "123"
                },
                new Student
                {
                    FirstName = "Даниил",
                    LastName = "Святославович",
                    GroupNumber = "123"
                },
            };
        }

        public IEnumerable<Student> GetAll()
        {
            return students;
        }
    }
}
