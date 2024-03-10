using Jobdoon.Models.Entities;

namespace Jobdoon.ViewModels
{
    public class AccountViewModel
    {
        public AppUser AppUser { get; set; }
        public int BirthDay { get; set; }
        public int BirthMonth { get; set; }
        public int BirthYear { get; set; }
        public IFormFile ProfileImageFile { get; set; }
    }
}
