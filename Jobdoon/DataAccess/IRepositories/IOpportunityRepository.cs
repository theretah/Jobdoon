using Jobdoon.Models.Entities;
using System.Linq.Expressions;

namespace Jobdoon.DataAccess.IRepositories
{
    public interface IOpportunityRepository : IRepository<Opportunity>
    {
        IEnumerable<Opportunity> FindIncluded(Expression<Func<Opportunity, bool>> predicate);
    }
}
