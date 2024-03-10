using Jobdoon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jobdoon.DbContextConfiguration
{
    public class OpportunityEntityTypeConfiguration : IEntityTypeConfiguration<Opportunity>
    {
        public void Configure(EntityTypeBuilder<Opportunity> builder)
        {
            builder.HasOne(o => o.Experience)
                .WithMany(e => e.Opportunities);

            builder.HasOne(o => o.Province)
               .WithMany(p => p.Opportunities);

            builder.HasOne(o => o.Category)
               .WithMany(c => c.Opportunities);

            builder.HasOne(o => o.Assignment)
               .WithMany(a => a.Opportunities);

            builder.HasOne(o => o.MinimumSalary)
              .WithMany(ms => ms.Opportunities);

            builder.HasOne(o => o.Gender)
              .WithMany(g => g.Opportunities);

            builder.HasOne(o => o.Company)
            .WithMany(c => c.Opportunities)
            .HasForeignKey(o => o.CompanyId);
        }
    }
}
