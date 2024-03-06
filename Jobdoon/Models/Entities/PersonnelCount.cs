namespace Jobdoon.Models.Entities
{
    public class PersonnelCount
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public IEnumerable<Company> Companies { get; set; }
    }
}
