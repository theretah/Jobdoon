using Jobdoon.Models.Entities;

namespace Jobdoon.DataAccess.IRepositories
{
    public interface IDegreeRepository : IRepository<Degree>
    {
        IEnumerable<Degree> GetValids();
    }
}
