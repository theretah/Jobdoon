using Jobdoon.Models.Entities;

namespace Jobdoon.ViewModels
{
    public class CreateEditCompanyViewModel
    {
        public Company Company { get; set; }
        public IFormFile LogoImageFile { get; set; }
        public IFormFile BannerImageFile { get; set; }
        public IFormFile BuildingImageFile { get; set; }
    }
}
