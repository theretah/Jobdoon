using Jobdoon.DataAccess.IRepositories;
using Jobdoon.Database;
using Jobdoon.Models.Entities;

namespace Jobdoon.DataAccess.Repositories
{
    public class CompanyCategoryRepository : Repository<CompanyCategory>, ICompanyCategoryRepository
    {
        public CompanyCategoryRepository(JobdoonContext context) : base(context)
        {
        }
    }
}
