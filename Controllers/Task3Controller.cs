using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using netBootcamp.TASK_3;
using netBootcamp.TASK_3.BootcampContext;

namespace netBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Task3Controller : ControllerBase
    {
        private readonly BootcampContext _context;
        public Task3Controller()
        {
            _context = new BootcampContext();
        }
        [HttpGet]
        public IActionResult Get()
        {
            var values = _context.Employees.ToList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (employee == null)
            {
                return BadRequest("Employee was not found");
            }
            else
            {
                return Ok(employee);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (employee == null)
            {
                return BadRequest();
            }
            else
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
                return Ok("employee has been deleted successfully");
            }

        }
        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {

            _context.Employees.Update(employee);
            _context.SaveChanges();
            return Ok("employee has been updated successfully");
        }
        [HttpPost]
        public IActionResult CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return Ok("employee has been created successfully");

        }


    }
}
