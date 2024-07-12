namespace CustomerDetails.Controllers
{
    using CustomerDetails.Interfaces;
    using CustomerDetails.Models;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService service;

        public CustomerController(ICustomerService customerService)
        {
            service = customerService;
        }

        [HttpGet]
        public ActionResult<List<Customer>> GetAllCustomers()
        {
            var customers = service.GetAllCustomers();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var customer = service.GetCustomerById(id);
            if (customer == null)
            {
                return NoContent();
            }
            return Ok(customer);
        }
    }
}
