using EmployeeData;
using Microsoft.AspNetCore.Mvc;
using EmployeeModel;

namespace Employee.Controllers
{
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _mockEmployee;

        public EmployeeController(IEmployee MockEmployee)
        {
            _mockEmployee = MockEmployee;
        }

        [HttpGet]
        [Route("api/[controller]")]

        public IActionResult GetEmployees()
        {
            return Ok(_mockEmployee.GetAllEmployees());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]

        public IActionResult GetEmployee(string id)
        {
            var employee = _mockEmployee.GetEmployeeById(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            return BadRequest("Employee Does Not Exist");
        }

        [HttpPost]
        [Route("api/[controller]")]

        public IActionResult AddEmployee(Employees employee)
        {
            return Ok(_mockEmployee.AddEmployee(employee));
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]

        public IActionResult DeleteEmployee(string id)
        {
            var employee = _mockEmployee.GetEmployeeById(id);
            if (employee != null)
            {
                _mockEmployee.DeleteEmployee(employee);
                return Ok("Employee Terminated");
            }
            return BadRequest("Employee Does Not Exist");
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]

        public IActionResult UpdateEmployee(string id, Employees employee)
        {
            var exists = _mockEmployee.GetEmployeeById(id);
            if (exists != null)
            {
                _mockEmployee.UpdateEmployee(employee,id);
                return Ok("Employee Details Updated");
            }
            return BadRequest("Employee Does Not Exist");
        }


    }
}
