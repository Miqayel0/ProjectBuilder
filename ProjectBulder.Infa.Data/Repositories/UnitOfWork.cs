using Microsoft.EntityFrameworkCore;
using ProjectBuilder.Domain.Interfaces;
using ProjectBulder.Infa.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBulder.Infa.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Complete()
        {
            foreach (var entry in _context.ChangeTracker.Entries())
            {
                if (entry.Entity is ITrackable trackable)
                {
                    var now = DateTime.UtcNow;
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            trackable.LastUpdatedAt = now;
                            break;

                        case EntityState.Added:
                            trackable.CreatedAt = now;
                            trackable.LastUpdatedAt = now;
                            break;
                    }
                }
            }
            _context.SaveChanges();
        }
    }
}
