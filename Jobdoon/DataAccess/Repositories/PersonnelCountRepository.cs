using Jobdoon.DataAccess.IRepositories;
using Jobdoon.Database;
using Jobdoon.Models.Entities;

namespace Jobdoon.DataAccess.Repositories
{
    public class PersonnelCountRepository : Repository<PersonnelCount>, IPersonnelCountRepository
    {
        public PersonnelCountRepository(JobdoonContext context) : base(context)
        {
        }
    }
}
