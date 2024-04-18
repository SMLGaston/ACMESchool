using ACMESchool.src.Domain;

namespace ACMESchool.src.Application.Repositories
{
    public interface ICourseRepository
    {
        void Register(Course course);
        Course GetById(long id);
    }
}
