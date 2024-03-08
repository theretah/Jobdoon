using Jobdoon.Models.Entities;

namespace Jobdoon.DataAccess.IRepositories
{
    public interface IMilitaryServiceRepository : IRepository<MilitaryService>
    {
        IEnumerable<MilitaryService> GetValids();
    }
}
