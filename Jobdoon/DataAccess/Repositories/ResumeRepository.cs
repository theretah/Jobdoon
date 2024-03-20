using Jobdoon.DataAccess.IRepositories;
using Jobdoon.Database;
using Jobdoon.Models.Entities;

namespace Jobdoon.DataAccess.Repositories
{
    public class ResumeRepository : Repository<Resume>, IResumeRepository
    {
        private readonly JobdoonContext context;

        public ResumeRepository(JobdoonContext context) : base(context)
        {
            this.context = context;
        }

        public Resume GetByEmployeeId(string employeeId)
        {
            return context.Resumes.Where(r => r.EmployeeId == employeeId).SingleOrDefault();
        }

        public void Update(Resume resume)
        {
            context.Update(resume);
        }
    }
}
