using Microsoft.AspNetCore.Mvc;

namespace Labo_Agence_Voyage.ASP_MVC.Controllers
{
    //TODO: not implemented
    public class ReservationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Creer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Creer(object obj)
        {
            return View();
        }
    }
}
