using ACMESchool.src.Application.Ports;
using ACMESchool.src.Application.Repositories;

namespace ACMESchool.src.Application.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IPaymentPort _paymentPort;

        public RegistrationService(IStudentRepository studentRepository, ICourseRepository courseRepository, IPaymentPort paymentPort)
        {
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
            _paymentPort = paymentPort;
        }

        public void RegisterStudentToCourse(int studentId, int courseId)
        {
            var student = _studentRepository.GetById(studentId);
            var course = _courseRepository.GetById(courseId);

            if (student != null && course != null)
            {
                if (_paymentPort.ProcessPayment(student, course))
                {
                    student.Courses.Add(course);
                }
            }
        }
    }
}
