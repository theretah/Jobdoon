using Jobdoon.DataAccess.IRepositories;
using Jobdoon.Database;
using Jobdoon.Models.Entities;

namespace Jobdoon.DataAccess.Repositories
{
    public class JobCategoryRepository : Repository<JobCategory>, IJobCategoryRepository
    {
        public JobCategoryRepository(JobdoonContext context) : base(context)
        {
        }
    }
}
