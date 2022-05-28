using HM_APIs.Data;
using HM_APIs.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace HM_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ApplicationDbContext _context; //{ get; set;}
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _context.Customer.ToList();
        }
        [HttpPost]
        public Customer Post([FromQuery] Customer Customer)
        {
            _context.Customer.Add(Customer);
            _context.SaveChanges(); 
            return Customer;
        }
    }


}

