using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectBuilder.Domain.Entities;

namespace ProjectBulder.Infa.Data.EfConfig
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            var converter = new EnumToStringConverter<ProjectStatus>();

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Amount).HasColumnType(Constants.Constants.Strings.SqlDataTypes.SqlDecimal);
            builder.Property(p => p.DonatedAmount).HasColumnType(Constants.Constants.Strings.SqlDataTypes.SqlDecimal);
            builder.HasOne(p => p.Initiator).WithMany(u => u.InitialProjects);
            builder.HasMany(p => p.Donations).WithOne(d => d.Project).HasForeignKey(d => d.ProjectId);
            builder.Property(p => p.Status).HasConversion(converter);
        }
    }
}