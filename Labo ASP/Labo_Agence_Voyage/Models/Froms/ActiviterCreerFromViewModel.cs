using System.ComponentModel.DataAnnotations;

namespace Labo_Agence_Voyage.ASP_MVC.Models.Froms
{
    public class ActiviterCreerFromViewModel
    {
        [Required(ErrorMessage = "Le nom est requis")]
        [Display(Name = "Nom de l'activité")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "La description est requis")]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Le prix est requis")]
        [Range(1.00, 1_000_000_000.00, ErrorMessage = "Le prix doit être compris entre 1.00 et 1 000 000 000.00")]
        [DataType(DataType.Currency, ErrorMessage = "Le type de valeur saisi n'est pas correct")]
        [Display(Name = "Prix (EUR)")]
        [DisplayFormat(DataFormatString = "{0:0.##}")]
        public decimal Prix { get; set; }

        [Required(ErrorMessage = "Une destination est requis")]
        [Display(Name = "Destination")]
        public Guid DestinationId { get; set; }
    }
}
