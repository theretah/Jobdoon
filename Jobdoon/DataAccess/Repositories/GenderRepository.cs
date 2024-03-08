using Jobdoon.DataAccess.IRepositories;
using Jobdoon.Database;
using Jobdoon.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Jobdoon.DataAccess.Repositories
{
    public class GenderRepository : Repository<Gender>, IGenderRepository
    {
        public GenderRepository(JobdoonContext context) : base(context)
        {
        }

        public IEnumerable<Gender> GetValids()
        {
            return JobdoonContext.Genders.Where(g => g.Title != "مهم نیست");
        }
        public JobdoonContext JobdoonContext
        {
            get
            {
                return Context as JobdoonContext;
            }
        }
    }
}
