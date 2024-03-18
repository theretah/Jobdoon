using Jobdoon.Models.Entities;
using System.Linq.Expressions;

namespace Jobdoon.DataAccess.IRepositories
{
    public interface IRequestRepository : IRepository<Request>
    {
        void Update(Request request);
        IEnumerable<Request> FindIncluded(Expression<Func<Request, bool>> predicate);
    }
}
