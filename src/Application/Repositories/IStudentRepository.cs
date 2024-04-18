using ACMESchool.src.Domain;

namespace ACMESchool.src.Application.Repositories
{
    public interface IStudentRepository
    {
        void Register(Student student);
        Student GetById(long id);
        List<Student> GetAll();
    }
}
