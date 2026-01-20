using System.ComponentModel.DataAnnotations;

namespace Labo_Agence_Voyage.ASP_MVC.Models
{
    public class DestinationViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Pays")]
        public string Pays { get; set;  }

        [Display(Name = "Nom")]
        public string Nom { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }
    }
}
