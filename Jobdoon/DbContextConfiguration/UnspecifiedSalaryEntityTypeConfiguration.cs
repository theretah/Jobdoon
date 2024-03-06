using Jobdoon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jobdoon.DbContextConfiguration
{
    public class UnspecifiedSalaryEntityTypeConfiguration : IEntityTypeConfiguration<UnspecifiedSalary>
    {
        public void Configure(EntityTypeBuilder<UnspecifiedSalary> builder)
        {
            builder.HasMany(p => p.Opportunities)
                .WithOne(o => o.UnspecifiedSalary)
                .HasForeignKey(o => o.ExperienceId);
        }
    }
}
