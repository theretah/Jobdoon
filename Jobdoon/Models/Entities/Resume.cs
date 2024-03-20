namespace Jobdoon.Models.Entities
{
    public class Resume
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] Content { get; set; }

        public string EmployeeId { get; set; }
        public AppUser Employee { get; set; }
    }
}
