using Application.Commands.Employee;
using Application.Queries.Employee;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee([FromBody] AddEmployeeToProjectCommand command)
        {
            return Ok(await  _mediator.Send(command));
        }

        [HttpDelete("DeleteEmployee")]
        public async Task<IActionResult> DeleteEmployee(DeleteEmployeeFromProjectCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees(GetAllEmployeesQuerie command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet("GetEmployeesFromProject")]
        public async Task<IActionResult> GetEmployeesFromProject(GetEmployeesFromProjectQuerie command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
