using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using netBootcamp.TASK_3.BootcampContext;

namespace netBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Task4Controller : ControllerBase
    {
        private readonly BootcampContext _context;
        public Task4Controller()
        {
            _context = new BootcampContext();
        }
        [HttpGet]
        public IActionResult Get()
        {
            var orders = _context.WebUsers.Include(x => x.Order).ToList();
            return Ok(orders);
        }

    }
}
