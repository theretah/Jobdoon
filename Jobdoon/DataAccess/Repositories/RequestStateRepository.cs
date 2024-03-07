using Jobdoon.DataAccess.IRepositories;
using Jobdoon.Database;
using Jobdoon.Models.Entities;

namespace Jobdoon.DataAccess.Repositories
{
    public class RequestStateRepository : Repository<RequestState>, IRequestStateRepository
    {
        public RequestStateRepository(JobdoonContext context) : base(context)
        {
        }
    }
}
