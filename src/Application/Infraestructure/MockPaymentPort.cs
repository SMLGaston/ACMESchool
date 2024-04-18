using ACMESchool.src.Application.Ports;
using ACMESchool.src.Domain;

namespace ACMESchool.src.Application.Infraestructure
{
    public class MockPaymentPort : IPaymentPort
    {
        public bool ProcessPayment(Student student, Course course)
        {
            return true;
        }
    }
}
