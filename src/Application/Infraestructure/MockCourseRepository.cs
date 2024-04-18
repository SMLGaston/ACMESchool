using ACMESchool.src.Application.Repositories;
using ACMESchool.src.Domain;

namespace ACMESchool.src.Application.Infraestructure
{
    public class MockCourseRepository : ICourseRepository
    {
        private readonly List<Course> _courses = new List<Course>();
        public MockCourseRepository()
        {
            _courses.Add(new Course
            {
                Id = 1,
                Name = "Literature",
                StartDate = new DateTime(2024, 1, 30),
                EndDate = new DateTime(2024, 7, 15),
                RegistrationFee = 370
            });

            _courses.Add(new Course
            {
                Id = 2,
                Name = "Stadistics",
                StartDate = new DateTime(2024, 3, 1),
                EndDate = new DateTime(2024, 11, 30),
                RegistrationFee = 500
            });

            _courses.Add(new Course
            {
                Id = 3,
                Name = "Design",
                StartDate = new DateTime(2024, 9, 14),
                EndDate = new DateTime(2024, 12, 10),
                RegistrationFee = 250
            });

            _courses.Add(new Course
            {
                Id = 4,
                Name = "Management",
                StartDate = new DateTime(2024, 8, 7),
                EndDate = new DateTime(2024, 12, 20),
                RegistrationFee = 310
            });
        }

        public Course GetById(long id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }

        public void Register(Course course)
        {
            _courses.Add(course);
        }
    }
}
