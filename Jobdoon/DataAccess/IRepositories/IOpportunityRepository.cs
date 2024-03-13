using Jobdoon.Models.Entities;
using System.Linq.Expressions;

namespace Jobdoon.DataAccess.IRepositories
{
    public interface IOpportunityRepository : IRepository<Opportunity>
    {
        void Update(Opportunity opportunity);
    }
}
