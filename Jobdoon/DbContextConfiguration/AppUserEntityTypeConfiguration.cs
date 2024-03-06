using Jobdoon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jobdoon.DbContextConfiguration
{
    public class AppUserEntityTypeConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasOne(u => u.Company)
                .WithOne(c => c.Employer)
                .HasForeignKey<Company>(c => c.EmployerId);

            builder.HasOne(u => u.Gender)
                .WithMany(g => g.Employees);

            builder.HasOne(u => u.MilitaryService)
                .WithMany(g => g.Employees);

            builder.HasOne(u => u.Degree)
                .WithMany(g => g.Employees);
        }
    }
}
