namespace Jobdoon.Models.Entities
{
    public class Opportunity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool IsClosed { get; set; }

        public Province Province { get; set; }
        public int ProvinceId { get; set; }

        public Degree Degree { get; set; }
        public int DegreeId { get; set; }

        public JobCategory JobCategory { get; set; }
        public int JobCategoryId { get; set; }

        public Assignment Assignment { get; set; }
        public int AssignmentId { get; set; }

        public Experience Experience { get; set; }
        public int ExperienceId { get; set; }

        public MinimumSalary MinimumSalary { get; set; }
        public int MinimumSalaryId { get; set; }

        public MilitaryService MilitaryService { get; set; }
        public int MilitaryServiceId { get; set; }

        public Gender Gender { get; set; }
        public int GenderId { get; set; }

        public Company? Company { get; set; }
        public int? CompanyId { get; set; }

        public IEnumerable<Save>? Saves{ get; set; }
        public IEnumerable<Request>? Requests { get; set; }
    }
}
