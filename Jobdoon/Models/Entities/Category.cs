namespace Jobdoon.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public IEnumerable<Opportunity> Opportunities { get; set; }
        public IEnumerable<Company> Companies { get; set; }
    }
}
