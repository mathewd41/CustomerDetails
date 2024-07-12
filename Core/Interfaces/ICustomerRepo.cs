using CustomerDetails.Models;
namespace CustomerDetails.Interfaces
{
    public interface ICustomerRepo
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
    }
}
