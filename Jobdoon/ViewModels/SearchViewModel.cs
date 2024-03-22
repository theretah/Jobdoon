using Jobdoon.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Jobdoon.ViewModels
{
    public class SearchViewModel
    {
        public string SearchQuery { get; set; }
        public IEnumerable<Opportunity> Opportunities { get; set; }

        public List<int> SelectedJobCategories { get; set; } = new List<int>();
        public SelectList JobCategoriesSelectList { get; set; }

        public List<int> SelectedProvinces { get; set; } = new List<int>();
        public SelectList ProvincesSelectList { get; set; }

        public List<int> SelectedAssignments { get; set; } = new List<int>();
        public SelectList AssignmentsSelectList { get; set; }

        public List<int> SelectedExperiences { get; set; } = new List<int>();
        public SelectList ExperiencesSelectList { get; set; }

        public List<int> SelectedSalaries { get; set; } = new List<int>();
        public SelectList SalariesSelectList { get; set; }
    }

}
