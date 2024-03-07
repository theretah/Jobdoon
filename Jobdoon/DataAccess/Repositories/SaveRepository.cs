using Jobdoon.DataAccess.IRepositories;
using Jobdoon.Database;
using Jobdoon.Models.Entities;

namespace Jobdoon.DataAccess.Repositories
{
    public class SaveRepository : Repository<Save>, ISaveRepository
    {
        public SaveRepository(JobdoonContext context) : base(context)
        {
        }
    }
}
