using Jobdoon.Models.Entities;

namespace Jobdoon.DataAccess.IRepositories
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company company);
    }
}
