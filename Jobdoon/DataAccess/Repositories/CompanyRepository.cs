using Jobdoon.DataAccess.IRepositories;
using Jobdoon.Database;
using Jobdoon.Models.Entities;

namespace Jobdoon.DataAccess.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly JobdoonContext context;

        public CompanyRepository(JobdoonContext context) : base(context)
        {
            this.context = context;
        }

        public void Update(Company company)
        {
            context.Update(company);
        }
    }
}
