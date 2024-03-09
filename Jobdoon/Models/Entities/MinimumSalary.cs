namespace Jobdoon.Models.Entities
{
    public class MinimumSalary
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int? Value { get; set; }

        public IEnumerable<Opportunity> Opportunities { get; set; }
    }
}
