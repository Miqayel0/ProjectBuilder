using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectBuilder.Application.Dtos.Project;
using ProjectBuilder.Application.Interfaces;
using ProjectBuilder.WebAPI.Models.Project;

namespace ProjectBuilder.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<ActionResult<ProjectListViewModel>> Get()
        {
            return Ok(new ProjectListViewModel { Projects = await _projectService.Get() });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectDto>> Get(int id)
        {
            return Ok(await _projectService.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm] CreateProjectDto input)
        {
            await _projectService.Add(input);
            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
