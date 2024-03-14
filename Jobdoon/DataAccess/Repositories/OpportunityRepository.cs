using Jobdoon.DataAccess.IRepositories;
using Jobdoon.Database;
using Jobdoon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Jobdoon.DataAccess.Repositories
{
    public class OpportunityRepository : Repository<Opportunity>, IOpportunityRepository
    {
        private readonly JobdoonContext context;

        public OpportunityRepository(JobdoonContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Opportunity> GetLatest()
        {
            return context.Opportunities.OrderByDescending(o => o.Date).ToList();
        }

        public void Update(Opportunity opportunity)
        {
            context.Opportunities.Update(opportunity);
        }
    }
}
