using Jobdoon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jobdoon.DbContextConfiguration
{
    public class MinimumSalaryEntityTypeConfiguration : IEntityTypeConfiguration<MinimumSalary>
    {
        public void Configure(EntityTypeBuilder<MinimumSalary> builder)
        {
            builder.HasMany(p => p.Opportunities)
                .WithOne(o => o.MinimumSalary)
                .HasForeignKey(o => o.ExperienceId);
        }
    }
}
