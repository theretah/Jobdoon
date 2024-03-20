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
    public class ResumeEntityTypeConfiguration : IEntityTypeConfiguration<Resume>
    {
        public void Configure(EntityTypeBuilder<Resume> builder)
        {
            builder.HasOne(r => r.Employee)
                .WithOne(e => e.ResumeAppendix)
                .HasForeignKey<AppUser>(e => e.ResumeAppendixId);
        }
    }
}
