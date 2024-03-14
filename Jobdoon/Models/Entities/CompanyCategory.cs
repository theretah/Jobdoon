namespace Jobdoon.Models.Entities
{
    public class CompanyCategory
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public IEnumerable<Company> Companies { get; set; }
    }
}
