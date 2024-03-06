namespace Jobdoon.Models.Entities
{
    public class Save
    {
        public AppUser Employee { get; set; }
        public string EmployeeId { get; set; }

        public Opportunity Opportunity { get; set; }
        public int OpportunityId { get; set; }
    }
}
