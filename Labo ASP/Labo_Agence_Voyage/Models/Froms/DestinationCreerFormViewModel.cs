using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Labo_Agence_Voyage.ASP_MVC.Models.Froms
{
    public class DestinationCreerFormViewModel
    {
        [Required(ErrorMessage = "Le nom du pays est requis")]
        [DisplayName("Entrez le pays")]
        public string Pays { get; set; }

        [Required(ErrorMessage = "Le nom de la destination est requis")]
        [DisplayName("Entrez le nom de la destination")]
        public string Nom { get; set; }

        [DisplayName("Entrez une description")]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
    }
}
