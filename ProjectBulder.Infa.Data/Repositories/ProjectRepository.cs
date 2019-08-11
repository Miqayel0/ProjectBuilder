using ProjectBuilder.Domain.Entities;
using ProjectBuilder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBulder.Infa.Data.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        public Task Add(Project project)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Project project)
        {
            throw new NotImplementedException();
        }

        public Task Update(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
