using Jobdoon.Models.Entities;

namespace Jobdoon.DataAccess.IRepositories
{
    public interface IResumeRepository : IRepository<Resume>
    {
        Resume GetByEmployeeId(string employeeId);
        void Update(Resume resume);
    }
}
