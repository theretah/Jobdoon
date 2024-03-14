using Jobdoon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jobdoon.DbContextConfiguration
{
    public class JobCategoryEntityTypeConfiguration : IEntityTypeConfiguration<JobCategory>
    {
        public void Configure(EntityTypeBuilder<JobCategory> builder)
        {
            builder.HasMany(p => p.Opportunities)
                .WithOne(o => o.JobCategory)
                .HasForeignKey(o => o.JobCategoryId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
