using ProjectBuilder.Application.Dtos.Project;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBuilder.Application.Interfaces
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectDto>> Get();
        Task<ProjectDto> GetById(string id);
        Task Add(CreateProjectDto project);
        Task Remove(ProjectDto project);
        Task Update(ProjectDto project);
    }
}
