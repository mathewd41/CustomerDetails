
using CustomerDetails.Interfaces;
using CustomerDetails.Models;

namespace Infrastructure.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo repo;

        public CustomerService(ICustomerRepo customerRepo)
        {
            repo = customerRepo;
        }

        public List<Customer> GetAllCustomers()
        {
            return repo.GetAllCustomers();
        }
     
        public Customer GetCustomerById(int id)
        {
            return repo.GetCustomerById(id);
        }
         
    }
}
