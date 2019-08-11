using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectBuilder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBulder.Infa.Data.EfConfig
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(u => u.InitialProjects).WithOne(p => p.Initiator).HasForeignKey(u => u.InitiatorId);
            builder.HasMany(p => p.Donations).WithOne(d => d.User).HasForeignKey(d => d.UserId);
        }
    }
}
