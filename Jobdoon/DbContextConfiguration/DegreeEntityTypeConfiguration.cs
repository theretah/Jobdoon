using Jobdoon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jobdoon.DbContextConfiguration
{
    public class DegreeEntityTypeConfiguration : IEntityTypeConfiguration<Degree>
    {
        public void Configure(EntityTypeBuilder<Degree> builder)
        {
            builder.HasMany(p => p.Opportunities)
                .WithOne(o => o.Degree)
                .HasForeignKey(o => o.DegreeId);

            builder.HasMany(p => p.Employees)
             .WithOne(o => o.Degree)
             .HasForeignKey(o => o.DegreeId);
        }
    }
}
