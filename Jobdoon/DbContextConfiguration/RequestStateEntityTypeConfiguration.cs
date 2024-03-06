using Jobdoon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jobdoon.DbContextConfiguration
{
    public class RequestStateEntityTypeConfiguration : IEntityTypeConfiguration<RequestState>
    {
        public void Configure(EntityTypeBuilder<RequestState> builder)
        {
            builder.HasMany(rs => rs.Requests)
               .WithOne(r => r.RequestState)
               .HasForeignKey(r => r.RequestStateId);
        }
    }
}
