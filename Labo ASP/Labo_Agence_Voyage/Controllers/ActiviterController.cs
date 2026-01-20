using Labo_Agence_Voyage.ASP_MVC.Models.Froms;
using Microsoft.AspNetCore.Mvc;

namespace Labo_Agence_Voyage.ASP_MVC.Controllers
{
    public class ActiviterController : Controller
    {
        [HttpGet]
        public IActionResult Creer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Creer(ActiviterCreerFromViewModel form)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction(nameof(Creer));
        }
    }
}
