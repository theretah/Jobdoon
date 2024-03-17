namespace Jobdoon.Models.Entities
{
    public class Request
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public AppUser Employee { get; set; }
        public string EmployeeId { get; set; }

        public Opportunity Opportunity { get; set; }
        public int OpportunityId { get; set; }

        public RequestState RequestState { get; set; }
        public int RequestStateId { get; set; }
    }
}
