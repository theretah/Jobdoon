using Jobdoon.Models.Entities;

namespace Jobdoon.DataAccess.IRepositories
{
    public interface IGenderRepository : IRepository<Gender>
    {
        IEnumerable<Gender> GetValids();
    }
}
