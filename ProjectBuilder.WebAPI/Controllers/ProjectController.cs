using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectBuilder.Application.Dtos.Project;
using ProjectBuilder.Application.Interfaces;
using ProjectBuilder.WebAPI.Models.Project;

namespace ProjectBuilder.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            await Task.CompletedTask;
            return Ok();
        }

        [HttpGet]
        [Route("finished")]
        public async Task<ActionResult<ProjectListViewModel>> GetFinished()
        {
            return Ok(new ProjectListViewModel { Projects = await _projectService.GetFinished() });
        }

        [HttpGet]
        [Route("ongoing")]
        public async Task<ActionResult<ProjectListViewModel>> GetOngoing()
        {
            return Ok(new ProjectListViewModel { Projects = await _projectService.GetOngoing() });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectDto>> Get(int id)
        {
            return Ok(await _projectService.GetById(id));
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Post([FromForm] CreateProjectDto input)
        {
            await _projectService.Add(input);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ProjectDto>> Donate(int id, [FromBody] DonationAmountInput input)
        {
            var project = await _projectService.Donate(new CreateDonationDto { Amount = input.Amount, Id = id });
            return Ok(project);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
