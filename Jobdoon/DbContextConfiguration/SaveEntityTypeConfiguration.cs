using Jobdoon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jobdoon.DbContextConfiguration
{
    public class SaveEntityTypeConfiguration : IEntityTypeConfiguration<Save>
    {
        public void Configure(EntityTypeBuilder<Save> builder)
        {
            builder.HasKey(s => new { s.EmployeeId, s.OpportunityId });

            builder.HasOne(s => s.Opportunity)
                .WithMany(o => o.Saves)
                .HasForeignKey(s => s.OpportunityId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(s => s.Employee)
                .WithMany(o => o.Saves)
                .HasForeignKey(s => s.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
