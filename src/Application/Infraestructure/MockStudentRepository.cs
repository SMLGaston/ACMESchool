using ACMESchool.src.Application.Repositories;
using ACMESchool.src.Domain;

namespace ACMESchool.src.Application.Infraestructure
{
    public class MockStudentRepository : IStudentRepository
    {
        private readonly List<Student> _students = new List<Student>();

        public MockStudentRepository()
        {
            _students.Add(new Student
            {
                Id = 1,
                Name = "Patrick",
                Courses = {
                    new Course
                    {
                        Id = 1,
                        Name = "Literature",
                        StartDate = new DateTime(2024,1,30),
                        EndDate = new DateTime(2024,7,15),
                        RegistrationFee = 370
                    },
                    new Course
                    {
                        Id = 3,
                        Name = "Design",
                        StartDate = new DateTime(2024,9,14),
                        EndDate = new DateTime(2024,12,10),
                        RegistrationFee = 250
                    }}
            });
            _students.Add(new Student
            {
                Id = 2,
                Name = "Vance",
                Courses = {
                    new Course
                    {
                        Id = 2,
                        Name = "Stadistics",
                        StartDate = new DateTime(2024,3,1),
                        EndDate = new DateTime(2024,11,30),
                        RegistrationFee = 500
                    },
                    new Course
                    {
                        Id = 4,
                        Name = "Management",
                        StartDate = new DateTime(2024,8,7),
                        EndDate = new DateTime(2024,12,20),
                        RegistrationFee = 310
                    }}
            });
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(long id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public void Register(Student student)
        {
            _students.Add(student);
        }
    }
}
