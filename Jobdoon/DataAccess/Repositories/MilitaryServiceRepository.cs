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

        public IEnumerable<MilitaryService> GetValids()
        {
            return JobdoonContext.MilitaryServices.Where(ms => ms.Title != "مهم نیست");
        }

        public JobdoonContext JobdoonContext { get { return Context as JobdoonContext; } }
    }
}
