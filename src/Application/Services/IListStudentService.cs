using ACMESchool.src.Application.DTOs;

namespace ACMESchool.src.Application.Services
{
    public interface IListStudentService
    {
        List<StudentListDTO> GetStudentCourses(DateTime StartDate, DateTime EndDate);
    }
}
