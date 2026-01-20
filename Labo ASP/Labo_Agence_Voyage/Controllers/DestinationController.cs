using Labo_Agence_Voyage.ASP_MVC.Models;
using Labo_Agence_Voyage.ASP_MVC.Models.Froms;
using Microsoft.AspNetCore.Mvc;

namespace Labo_Agence_Voyage.ASP_MVC.Controllers
{
    public class DestinationController : Controller
    {
        public IActionResult Index()
        {
            //TODO: requete api récup tout les destinations
            IEnumerable<DestinationViewModel> viewModel = [
                new DestinationViewModel() { Id = Guid.NewGuid(), Nom = "Paris", Pays = "France", Description = null },
                new DestinationViewModel() { Id = Guid.NewGuid(), Nom = "Paris", Pays = "France", Description = "Ville Lumière"}
            ];
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Creer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Creer(DestinationCreerFormViewModel form)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            //TODO: requete api créer destination
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(Guid id)
        {
            //TODO: requete api recup destination avec activites
            DestinationViewModel viewModel = new DestinationViewModel();
            viewModel.Id = id;
            viewModel.Nom = "Paris";
            viewModel.Pays = "France";
            return View(viewModel);
        }

    }
}
