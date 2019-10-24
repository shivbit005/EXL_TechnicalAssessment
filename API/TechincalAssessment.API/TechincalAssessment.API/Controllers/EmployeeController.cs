using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechnicalAssessment.API.Services.Models;

namespace TechincalAssessment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly TechnicalAssessment.API.Services.IEmployeeService _employeeService;

        public EmployeeController(TechnicalAssessment.API.Services.IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        // GET All Employee Information
        // GET: api/Employee
        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await _employeeService.ListEmployeesAsync();
        }


        // GET an Employee Information
        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<Employee> Get(int id)
        {
            return await _employeeService.ListEmployeeDetailsAsync(id);
        }


        // ADD NEW Employee
        // POST: api/Employee
        [HttpPost]
        public async Task<int> Post([FromBody] Employee employee)
        {
            return await _employeeService.AddNewEmployeeAsync(employee);
        }


        // Update an Employee Information
        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public async Task<int> Put(int id, [FromBody] Employee employee)
        {
            return await _employeeService.UpdateEmployeeDetailsAsync(id, employee);
        }
    }
}
