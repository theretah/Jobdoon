using Jobdoon.DataAccess.IRepositories;
using Jobdoon.Database;
using Jobdoon.Models.Entities;

namespace Jobdoon.DataAccess.Repositories
{
    public class UnspecifiedSalaryRepository : Repository<UnspecifiedSalary>, IUnspecifiedSalaryRepository
    {
        public UnspecifiedSalaryRepository(JobdoonContext context) : base(context)
        {
        }
    }
}
