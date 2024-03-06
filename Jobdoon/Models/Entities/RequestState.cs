namespace Jobdoon.Models.Entities
{
    public class RequestState
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public IEnumerable<Request> Requests { get; set; }
    }
}
