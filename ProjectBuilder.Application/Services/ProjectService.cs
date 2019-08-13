using AutoMapper;
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
        private readonly IMapper _mapper;
        public static IHostingEnvironment _environment;

        public ProjectService(IProjectRepository projectReposytory, IHostingEnvironment environment, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _projectReposytory = projectReposytory;
            _environment = environment;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task Add(CreateProjectDto project)
        {
            const string imgPath = @"\images\Project\";
            string imgUrl = "";
            var files = project.Files;

            var newProject = new Project
            {
                Name = project.Name,
                Description = project.Description,
                InitiatorName = project.InitiatorName,
                Amount = project.Amount,
                StartDate = project.StartDate,
                EndDate = project.EndDate,
                Location = project.Location,
                Status = ProjectStatus.Pending
            };

            await _projectReposytory.Add(newProject);

            if (files.Length > 0)
            {
                imgUrl = imgPath + Guid.NewGuid().ToString() + files.FileName;

                if (!Directory.Exists(_environment.WebRootPath + imgPath))
                {
                    Directory.CreateDirectory(_environment.WebRootPath + imgPath);
                }

                using (FileStream filestream = File.Create(_environment.WebRootPath + imgUrl))
                {
                    files.CopyTo(filestream);
                    filestream.Flush();
                }

                newProject.ImageUrl = imgUrl;
            }

            _unitOfWork.Complete();
        }

        public async Task<IEnumerable<ProjectDto>> Get()
        {
            var projects = await _projectReposytory.Get();
            var projectsDto = _mapper.Map<IEnumerable<ProjectDto>>(projects);

            return projectsDto;
        }

        public async Task<ProjectDto> GetById(int id)
        {
            var project = await _projectReposytory.GetById(id);
            var projectDto = _mapper.Map<ProjectDto>(project);

            return projectDto;
        }

        public Task Remove(ProjectDto project)
        {
            throw new NotImplementedException();
        }

        public Task Update(ProjectDto project)
        {
            throw new NotImplementedException();
        }

        public async Task Donate(CreateDonationDto donation)
        {
            const decimal _donationLimit = 10000000;
            var project = await _projectReposytory.GetById(donation.Id);

            if (project == null || project.Status == ProjectStatus.Finished || project.Status == ProjectStatus.Stoped ||
                   (project.DonatedAmount.HasValue && (project.DonatedAmount + donation.Amount > project.Amount)) || donation.Amount <= 0 || donation.Amount > _donationLimit)
            {
                throw new Exception("Something went wrong");
            }

            if (project.DonatedAmount.HasValue)
            {
                project.DonatedAmount += donation.Amount;
            }
            else
            {
                project.DonatedAmount = donation.Amount;
            }

            if (project.DonatedAmount == project.Amount)
            {
                project.Status = ProjectStatus.Finished;
            }

            _unitOfWork.Complete();
        }
    }
}
