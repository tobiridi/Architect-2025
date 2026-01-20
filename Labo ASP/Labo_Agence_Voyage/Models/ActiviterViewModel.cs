using System.ComponentModel.DataAnnotations;

namespace Labo_Agence_Voyage.ASP_MVC.Models
{
    public class ActiviterViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Nom de l'activité")]
        public string Nom { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Prix (EUR)")]
        public decimal Prix { get; set; }
    }
}
