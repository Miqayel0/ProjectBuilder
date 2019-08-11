using Microsoft.AspNetCore.Hosting;
using ProjectBuilder.Application.Dtos.Project;
using ProjectBuilder.Application.Interfaces;
using ProjectBuilder.Domain.Entities;
using ProjectBuilder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ProjectBuilder.Application.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectReposytory;
        private readonly IUnitOfWork _unitOfWork;
        public static IHostingEnvironment _environment;
        public ProjectService(IProjectRepository projectReposytory, IHostingEnvironment environment, IUnitOfWork unitOfWork)
        {
            _projectReposytory = projectReposytory;
            _environment = environment;
            _unitOfWork = unitOfWork;
        }
        public async Task Add(CreateProjectDto project)
        {
            const string imgPath = @"\images\Project\";
            string imgUrl = "";
            var files = project.Files;

            if (files.Length > 0)
            {
                imgUrl = imgPath + files.FileName;

                if (!Directory.Exists(_environment.WebRootPath + imgPath))
                {
                    Directory.CreateDirectory(_environment.WebRootPath + imgPath);
                }

                using (FileStream filestream = File.Create(_environment.WebRootPath + imgUrl))
                {
                    files.CopyTo(filestream);
                    filestream.Flush();
                }
            }

            var newProject = new Project
            {
                Name = project.Name,
                Description = project.Description,
                InitiatorName = project.InitiatorName,
                Amount = project.Amount,
                StartDate = project.StartDate,
                EndDate = project.EndDate,
                Location = project.Location,
                ImageUrl = imgUrl,
                Status = ProjectStatus.Pending
            };

            await _projectReposytory.Add(newProject);
            await _unitOfWork.Complete();
        }

        public async Task<IEnumerable<ProjectDto>> Get()
        {
             await _projectReposytory.Get();

            return null;
        }

        public Task<ProjectDto> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task Remove(ProjectDto project)
        {
            throw new NotImplementedException();
        }

        public Task Update(ProjectDto project)
        {
            throw new NotImplementedException();
        }
    }
}
