using ACMESchool.src.Domain;

namespace ACMESchool.src.Application.Ports
{
    public interface IPaymentPort
    {
        bool ProcessPayment(Student student, Course course);
    }
}
