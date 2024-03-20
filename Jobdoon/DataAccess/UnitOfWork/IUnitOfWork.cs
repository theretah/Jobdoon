using Jobdoon.DataAccess.IRepositories;

namespace Jobdoon.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IAssignmentRepository Assignments { get; }
        IJobCategoryRepository JobCategories { get; }
        ICompanyCategoryRepository CompanyCategories { get; }
        ICompanyRepository Companies { get; }
        IDegreeRepository Degrees { get; }
        IExperienceRepository Experiences { get; }
        IGenderRepository Genders { get; }
        IMilitaryServiceRepository MilitaryServices { get; }
        IOpportunityRepository Opportunities { get; }
        IPersonnelCountRepository PersonnelCounts { get; }
        IProvinceRepository Provinces { get; }
        IRequestRepository Requests { get; }
        IRequestStateRepository RequestStates { get; }
        ISaveRepository Saves { get; }
        IMinimumSalaryRepository MinimumSalaries { get; }
        IResumeRepository Resumes { get; }

        int Complete();
    }
}
