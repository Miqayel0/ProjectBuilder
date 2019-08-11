using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectBuilder.Domain.Entities;

namespace ProjectBulder.Infa.Data.EfConfig
{
    public class DonationConfiguration : IEntityTypeConfiguration<Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.CurrentDonation).HasColumnType(Constants.Constants.Strings.SqlDataTypes.SqlDecimal);
            builder.HasOne(d => d.User).WithMany(u => u.Donations).HasForeignKey(d => d.UserId);
            builder.HasOne(d => d.Project).WithMany(p => p.Donations).HasForeignKey(d => d.ProjectId);
        }
    }
}
