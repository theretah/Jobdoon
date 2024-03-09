
using Jobdoon.DbContextConfiguration;
using Jobdoon.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Reflection.Emit;

namespace Jobdoon.Database
{
    public class JobdoonContext(DbContextOptions<JobdoonContext> options) : IdentityDbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<Company> Companies { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<MilitaryService> MilitaryServices { get; set; }
        public DbSet<RequestState> RequestStates { get; set; }
        public DbSet<MinimumSalary> MinimumSalaries { get; set; }
        public DbSet<PersonnelCount> PersonnelCounts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<Request> Requests { get; set; }
        public DbSet<Save> Saves { get; set; }
    }
}
