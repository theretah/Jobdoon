using Jobdoon.DataAccess.IRepositories;
using Jobdoon.Database;
using Jobdoon.Models.Entities;

namespace Jobdoon.DataAccess.Repositories
{
    public class MinimumSalaryRepository : Repository<MinimumSalary>, IMinimumSalaryRepository
    {
        public MinimumSalaryRepository(JobdoonContext context) : base(context)
        {
        }
    }
}
