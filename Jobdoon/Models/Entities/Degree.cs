namespace Jobdoon.Models.Entities
{
    public class Degree
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public IEnumerable<AppUser> Employees { get; set; }
        public IEnumerable<Opportunity> Opportunities { get; set; }
    }
}
