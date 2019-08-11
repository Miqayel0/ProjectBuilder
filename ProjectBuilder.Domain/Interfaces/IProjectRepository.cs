using ProjectBuilder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBuilder.Domain.Interfaces
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> Get();
        Task<Project> GetById(int id);
        Task Add(Project project);
        Task Remove(Project project);
        Task Update(Project project);
    }
}
