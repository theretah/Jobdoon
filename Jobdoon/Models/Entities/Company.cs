namespace Jobdoon.Models.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string PersianName { get; set; }
        public string LatinName { get; set; }
        public string Telephone { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string? IntroductoryText { get; set; }

        public byte[] LogoImage { get; set; }
        public byte[]? BuildingImage { get; set; }
        public byte[]? BannerImage { get; set; }

        public AppUser Employer { get; set; }
        public string EmployerId { get; set; }

        public PersonnelCount PersonnelCount { get; set; }
        public int PersonnelCountId { get; set; }

        public CompanyCategory CompanyCategory { get; set; }
        public int CompanyCategoryId { get; set; }

        public IEnumerable<Opportunity>? Opportunities { get; set; }
    }
}
