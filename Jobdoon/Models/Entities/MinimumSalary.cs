using Jobdoon.Utilities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jobdoon.Models.Entities
{
    public class MinimumSalary
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int? Amount { get; set; }

        [NotMapped]
        public string ActualValue => Title == null ? StringUtilities.Divide3DigitsByComma(Amount.Value) : Title;

        public IEnumerable<Opportunity> Opportunities { get; set; }
    }
}
