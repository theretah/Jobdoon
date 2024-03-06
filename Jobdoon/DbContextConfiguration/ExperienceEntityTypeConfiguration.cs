using Jobdoon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jobdoon.DbContextConfiguration
{
    public class ExperienceEntityTypeConfiguration : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.HasMany(p => p.Opportunities)
                .WithOne(o => o.Experience)
                .HasForeignKey(o => o.ExperienceId);
        }
    }
}
