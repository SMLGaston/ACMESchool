using ACMESchool.src.Application.Infraestructure;
using ACMESchool.src.Domain;
using Xunit;

namespace ACMESchool.ACMESchoolTest
{
    public class StudentTest
    {
        [Fact]
        public void Register_Success()
        {
            // Arrange
            var mockStudentRepository = new MockStudentRepository();
            var student = new Student()
            {
                Id = 3,
                Name = "Alberto"
            };


            // Act
            mockStudentRepository.Register(student);

            // Assert
            var students = mockStudentRepository.GetAll();
            Assert.Contains(student, students);
        }
    }
}
