using ACMESchool.src.Application.Infraestructure;
using ACMESchool.src.Domain;
using Xunit;

namespace ACMESchool.ACMESchoolTest
{
    public class CourseTest
    {
        [Fact]
        public void Register_Success()
        {
            // Arrange
            var mockCourseRepository = new MockCourseRepository();

            var course = new Course()
            {
                Id = 5,
                Name = "Management",
                StartDate = new DateTime(2024, 6, 10),
                EndDate = new DateTime(2024, 11, 25),
                RegistrationFee = 290
            };

            // Act
            mockCourseRepository.Register(course);

            // Assert
            var courses = mockCourseRepository.GetById(course.Id);
            Assert.Equal(course, courses);
        }
    }
}
