
using CustomerDetails.Interfaces;
using CustomerDetails.Models;

namespace CustomerDetails.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly List<Customer> customers;

        public CustomerRepo()
        {

            customers = new List<Customer>
        {
            new Customer { Id = 1, FirstName = "Dhanya", LastName = "Mathew" },
            new Customer { Id = 2, FirstName = "Jane", LastName = "Joseph" }
        };
        }
        public List<Customer> GetAllCustomers() => customers;

        public Customer GetCustomerById(int id) => customers.FirstOrDefault(c => c.Id == id);
    }

 
    
}
