using Jobdoon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jobdoon.DbContextConfiguration
{
    public class CompanyCategoryEntityTypeConfiguration : IEntityTypeConfiguration<CompanyCategory>
    {
        public void Configure(EntityTypeBuilder<CompanyCategory> builder)
        {
            builder.HasMany(p => p.Companies)
                .WithOne(o => o.CompanyCategory)
                .HasForeignKey(o => o.CompanyCategoryId)
                .OnDelete(DeleteBehavior.NoAction);
            
        }
    }
}
