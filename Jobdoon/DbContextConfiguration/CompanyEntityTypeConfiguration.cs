﻿using Jobdoon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Hosting;
using System.Reflection.Emit;

namespace Jobdoon.DbContextConfiguration
{
    public class CompanyEntityTypeConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasOne(c => c.Employer)
                .WithOne(e => e.Company)
                .HasForeignKey<AppUser>(u => u.CompanyId);

            builder.HasOne(e => e.CompanyCategory)
                .WithMany(e => e.Companies);

            builder.HasMany(p => p.Opportunities)
               .WithOne(o => o.Company)
               .HasForeignKey(o => o.CompanyId);
        }
    }
}
