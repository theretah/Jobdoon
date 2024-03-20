using Microsoft.AspNetCore.Identity;

namespace Jobdoon.Models.Entities
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public bool IsEmployer { get; set; }
        public byte[]? ProfileImage { get; set; }
        public DateTime? BirthDate { get; set; }

        public Resume? ResumeAppendix { get; set; }
        public int? ResumeAppendixId { get; set; }

        public Gender? Gender { get; set; }
        public int? GenderId { get; set; }

        public Company? Company { get; set; }
        public int? CompanyId { get; set; }

        public MilitaryService? MilitaryService { get; set; }
        public int? MilitaryServiceId { get; set; }

        public Degree? Degree { get; set; }
        public int? DegreeId { get; set; }

        public IEnumerable<Save>? Saves { get; set; }
        public IEnumerable<Request>? Requests { get; set; }
    }
}
