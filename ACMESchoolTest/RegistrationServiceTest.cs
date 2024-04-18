using ACMESchool.src.Application.Infraestructure;
using ACMESchool.src.Application.Services;
using Xunit;

namespace ACMESchool.ACMESchoolTest
{
    public class RegistrationServiceTest
    {
        [Fact]
        public void RegisterStudentToCourse_Success()
        {
            // Arrange
            var mockStudentRepository = new MockStudentRepository();
            var mockCourseRepository = new MockCourseRepository();
            var mockPaymentPort = new MockPaymentPort();

            var registrationService = new RegistrationService(mockStudentRepository, mockCourseRepository, mockPaymentPort);

            int studentId = 1;
            int courseId = 1;

            // Act
            registrationService.RegisterStudentToCourse(studentId, courseId);

            // Assert
            var student = mockStudentRepository.GetById(studentId);
            var course = mockCourseRepository.GetById(courseId);

            Assert.Contains(course, student.Courses);
        }
    }
}
