using Jobdoon.DataAccess.IRepositories;
using Jobdoon.Database;
using Jobdoon.Models.Entities;

namespace Jobdoon.DataAccess.Repositories
{
    public class DegreeRepository : Repository<Degree>, IDegreeRepository
    {
        public DegreeRepository(JobdoonContext context) : base(context)
        {
        }

        public IEnumerable<Degree> GetValids()
        {
            return JobdoonContext.Degrees.Where(d => d.Title != "مهم نیست");
        }

        public JobdoonContext JobdoonContext { get { return Context as JobdoonContext; } }
    }
}
