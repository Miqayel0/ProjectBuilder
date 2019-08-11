using ProjectBuilder.Application.Dtos.Project;
using ProjectBuilder.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBuilder.Application.Services
{
    public class ProjectService : IProjectService
    {
        public Task Add(ProjectDto project)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProjectDto>> Get()
        {
            throw new NotImplementedException();
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
