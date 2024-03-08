using Jobdoon.Models.Entities;

namespace Jobdoon.ViewModels
{
    public class SearchViewModel
    {
        public IEnumerable<Province> Provinces { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Assignment> Assignments { get; set; }
        public IEnumerable<UnspecifiedSalary> UnspecifiedSalaries { get; set; }
        public IEnumerable<Experience> Experiences { get; set; }
    }
}
