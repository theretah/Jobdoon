using Jobdoon.Models.Entities;

namespace Jobdoon.DataAccess.IRepositories
{
    public interface ICompanyRepository : IRepository<Company>
    {
        IEnumerable<Company> GetTopCompanies();
        void Update(Company company);
    }
}
