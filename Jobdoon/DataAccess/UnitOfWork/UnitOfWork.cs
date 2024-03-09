using Jobdoon.DataAccess.IRepositories;
using Jobdoon.DataAccess.Repositories;
using Jobdoon.Database;

namespace Jobdoon.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly JobdoonContext context;

        public UnitOfWork(JobdoonContext context)
        {
            this.context = context;
            Assignments = new AssignmentRepository(context);
            Categories = new CategoryRepository(context);
            Companies = new CompanyRepository(context);
            Degrees = new DegreeRepository(context);
            Experiences = new ExperienceRepository(context);
            Genders = new GenderRepository(context);
            MilitaryServices = new MilitaryServiceRepository(context);
            Opportunities = new OpportunityRepository(context);
            PersonnelCounts = new PersonnelCountRepository(context);
            Provinces = new ProvinceRepository(context);
            Requests = new RequestRepository(context);
            RequestStates = new RequestStateRepository(context);
            Saves = new SaveRepository(context);
            MinimumSalaries = new MinimumSalaryRepository(context);
        }

        public IAssignmentRepository Assignments { get; private set; }

        public ICategoryRepository Categories { get; private set; }

        public ICompanyRepository Companies { get; private set; }

        public IDegreeRepository Degrees { get; private set; }

        public IExperienceRepository Experiences { get; private set; }

        public IGenderRepository Genders { get; private set; }

        public IMilitaryServiceRepository MilitaryServices { get; private set; }

        public IOpportunityRepository Opportunities { get; private set; }

        public IPersonnelCountRepository PersonnelCounts { get; private set; }

        public IProvinceRepository Provinces { get; private set; }

        public IRequestRepository Requests { get; private set; }

        public IRequestStateRepository RequestStates { get; private set; }

        public ISaveRepository Saves { get; private set; }

        public IMinimumSalaryRepository MinimumSalaries { get; private set; }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
