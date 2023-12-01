using Application.Commands.Project;
using Application.Queries.Project;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProjectController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjectController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AddProject")]
        public async Task<IActionResult> AddProject(AddProjectCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("DeleteProject")]
        public async Task<IActionResult> DeleteProject(DeleteProjectCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateProject")]
        public async Task<IActionResult> UpdateProject(UpdateProjectCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet("GetAllProjects")]
        public async Task<IActionResult> GetAllProjects(GetAllProjectsQuerie command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet("GetProjectsByEmployee")]
        public async Task<IActionResult> GetProjectsByEmployee(GetProjectsByEmployeeQuerie command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
