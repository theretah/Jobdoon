using Jobdoon.Models.Entities;
using System.Drawing;

namespace Jobdoon.ViewModels
{
    public class CreateEditCompanyViewModel
    {
        public Company Company { get; set; }
        public IFormFile LogoImageFile { get; set; }
    }
}
