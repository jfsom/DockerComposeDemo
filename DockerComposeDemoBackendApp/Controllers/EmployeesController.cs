using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerComposeDemoBackendApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = new[]
            {
            new { Id = 1, Name = "Rahul Sharma", Role = "Software Engineer", Department = "Development", Location = "Pune" },
            new { Id = 2, Name = "Priya Mehta", Role = "QA Engineer", Department = "Testing", Location = "Mumbai" },
            new { Id = 3, Name = "Amit Patil", Role = "DevOps Engineer", Department = "Cloud", Location = "Bangalore" },
            new { Id = 4, Name = "Sneha Jain", Role = "Project Manager", Department = "Management", Location = "Delhi" }
        };

            return Ok(employees);
        }
    }
}
