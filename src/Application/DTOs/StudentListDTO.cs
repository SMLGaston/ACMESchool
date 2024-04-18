using ACMESchool.src.Domain;

namespace ACMESchool.src.Application.DTOs
{
    public class StudentListDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        public StudentListDTO()
        {
            Courses = new List<Course>();
        }
    }
}
