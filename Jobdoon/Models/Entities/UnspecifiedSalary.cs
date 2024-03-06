namespace Jobdoon.Models.Entities
{
    public class UnspecifiedSalary
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public IEnumerable<Opportunity> Opportunities { get; set; }
    }
}
