using Jobdoon.DataAccess.IRepositories;
using Jobdoon.Database;
using Jobdoon.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jobdoon.DataAccess.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly JobdoonContext context;

        public CompanyRepository(JobdoonContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Company> GetTopCompanies()
        {
            return context.Companies.Include(c => c.Opportunities).OrderByDescending(c => c.Opportunities.Count()).ToList();
        }

        public void Update(Company company)
        {
            context.Update(company);
        }
    }
}
