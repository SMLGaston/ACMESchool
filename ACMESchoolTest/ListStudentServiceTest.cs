using ACMESchool.src.Application.DTOs;
using ACMESchool.src.Application.Infraestructure;
using ACMESchool.src.Application.Services;
using ACMESchool.src.Domain;
using Xunit;

namespace ACMESchool.ACMESchoolTest
{
    public class ListStudentServiceTest
    {
        [Fact]
        public void GetStudentCourses_Success()
        {
            // Arrange
            var mockStudentRepository = new MockStudentRepository();
            var listStudentService = new ListStudentService(mockStudentRepository);
            List<StudentListDTO> actualStudentListDTO = new List<StudentListDTO>();

            List<StudentListDTO> expectedStudentListDTO = new List<StudentListDTO>
            {
                new StudentListDTO
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
                        }}
                },
                new StudentListDTO
                {
                    Id  = 2,
                    Name = "Vance",
                    Courses = {
                        new Course
                        {
                            Id = 2,
                            Name = "Stadistics",
                            StartDate = new DateTime(2024,3,1),
                            EndDate = new DateTime(2024,11,30),
                            RegistrationFee = 500
                        }}
                },
            };

            DateTime startDate = new DateTime(2024, 4, 10);
            DateTime endDate = new DateTime(2024, 7, 10);

            // Act
            actualStudentListDTO = listStudentService.GetStudentCourses(startDate, endDate);

            // Assert
            Assert.Equal(expectedStudentListDTO.Count, actualStudentListDTO.Count);
            for (int i = 0; i < expectedStudentListDTO.Count; i++)
            {
                Assert.Equal(expectedStudentListDTO[i].Id, actualStudentListDTO[i].Id);
                Assert.Equal(actualStudentListDTO[i].Name, actualStudentListDTO[i].Name);
                Assert.True(actualStudentListDTO[i].Courses.All(item => actualStudentListDTO[i].Courses.Contains(item)));
            }
        }
    }
}
