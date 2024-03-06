using Jobdoon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jobdoon.DbContextConfiguration
{
    public class GenderEntityTypeConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasMany(g => g.Opportunities)
                 .WithOne(o => o.Gender)
                 .HasForeignKey(o => o.ExperienceId);

            builder.HasMany(g => g.Employees)
                .WithOne(e => e.Gender)
                .HasForeignKey(e => e.GenderId);
        }
    }
}
