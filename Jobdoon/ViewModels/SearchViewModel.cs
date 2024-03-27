using Jobdoon.Models.Entities;

namespace Jobdoon.ViewModels
{
    public class SearchViewModel
    {
        public IEnumerable<Opportunity> Opportunities { get; set; }

        public string? SearchQuery { get; set; }
        public int? SelectedProvince { get; set; }
        public int? SelectedJobCategory { get; set; }
    }
}
