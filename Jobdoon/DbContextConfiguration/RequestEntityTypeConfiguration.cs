using Jobdoon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jobdoon.DbContextConfiguration
{
    public class RequestEntityTypeConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.HasKey(r => r.Id);

            builder.HasOne(r => r.Opportunity)
                .WithMany(o => o.Requests)
                .HasForeignKey(r => r.OpportunityId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(r => r.Employee)
                .WithMany(o => o.Requests)
                .HasForeignKey(r => r.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
