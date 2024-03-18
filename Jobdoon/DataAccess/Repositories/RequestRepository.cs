using Jobdoon.DataAccess.IRepositories;
using Jobdoon.Database;
using Jobdoon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Jobdoon.DataAccess.Repositories
{
    public class RequestRepository : Repository<Request>, IRequestRepository
    {
        private readonly JobdoonContext context;

        public RequestRepository(JobdoonContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Request> FindIncluded(Expression<Func<Request, bool>> predicate)
        {
            return context.Requests.Where(predicate).Include(r => r.Opportunity).Include(r => r.Employee).Include(r => r.RequestState).ToList();
        }

        public void Update(Request request)
        {
            context.Requests.Update(request);
        }
    }
}
