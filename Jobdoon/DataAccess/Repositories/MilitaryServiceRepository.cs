using Jobdoon.DataAccess.IRepositories;
using Jobdoon.Database;
using Jobdoon.Models.Entities;

namespace Jobdoon.DataAccess.Repositories
{
    public class MilitaryServiceRepository : Repository<MilitaryService>, IMilitaryServiceRepository
    {
        public MilitaryServiceRepository(JobdoonContext context) : base(context)
        {
        }
    }
}
