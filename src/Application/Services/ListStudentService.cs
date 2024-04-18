using ACMESchool.src.Application.DTOs;
using ACMESchool.src.Application.Repositories;
using ACMESchool.src.Domain;

namespace ACMESchool.src.Application.Services
{
    public class ListStudentService : IListStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public ListStudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<StudentListDTO> GetStudentCourses(DateTime StartDate, DateTime EndDate)
        {
            List<Student> students = new List<Student>();
            List<StudentListDTO> studentListDTO = new List<StudentListDTO>();

            students = _studentRepository.GetAll();

            foreach (var student in students)
            {
                List<Course> courses = student.Courses.Where(y => y.StartDate >= StartDate && y.StartDate <= EndDate).ToList();
                studentListDTO.Add(new StudentListDTO { Id = student.Id, Name = student.Name, Courses = courses });
            }

            return studentListDTO;
        }
    }
}
