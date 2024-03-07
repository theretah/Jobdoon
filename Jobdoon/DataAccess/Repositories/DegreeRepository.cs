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
    }
}
