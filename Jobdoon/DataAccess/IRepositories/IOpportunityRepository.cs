using Jobdoon.Models.Entities;
using System.Linq.Expressions;

namespace Jobdoon.DataAccess.IRepositories
{
    public interface IOpportunityRepository : IRepository<Opportunity>
    {
        IEnumerable<Opportunity> GetAllWithCompany();
        IEnumerable<Opportunity> GetLatest();
        void Update(Opportunity opportunity);
    }
}
