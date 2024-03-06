namespace Jobdoon.Models.Entities
{
    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Opportunity> Opportunities { get; set; }
    }
}
