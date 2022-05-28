using HM_APIs.Data;
using HM_APIs.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace HM_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
       
        private readonly ApplicationDbContext _context; //{ get; set;}
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _context.User.ToList();
        }
    }


}
