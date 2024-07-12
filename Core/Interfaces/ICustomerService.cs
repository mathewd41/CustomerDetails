
using CustomerDetails.Models;

namespace CustomerDetails.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
    }
}
