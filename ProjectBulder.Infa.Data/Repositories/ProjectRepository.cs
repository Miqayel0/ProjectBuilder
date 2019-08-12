using Microsoft.EntityFrameworkCore;
using ProjectBuilder.Domain.Entities;
using ProjectBuilder.Domain.Interfaces;
using ProjectBulder.Infa.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBulder.Infa.Data.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _context;

        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(Project project)
        {
            await _context.AddAsync(project);
        }

        public async Task<IEnumerable<Project>> Get()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<Project> GetById(int id)
        {
            return await _context.Projects.FindAsync(id);
        }

        public Task Remove(Project project)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Project project)
        {
            await Task.FromResult(_context.Projects.Update(project));
        }
    }
}
