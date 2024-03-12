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

        public IEnumerable<Opportunity> FindIncluded(Expression<Func<Opportunity, bool>> predicate)
        {
            return context.Opportunities.Where(predicate).Include(o => o.Assignment).Include(o => o.Category)
                .Include(o => o.Company).Include(o => o.Experience).Include(o => o.Gender).Include(o => o.Degree)
                .Include(o => o.MilitaryService).Include(o => o.MinimumSalary).Include(o => o.Province);
        }
    }
}
