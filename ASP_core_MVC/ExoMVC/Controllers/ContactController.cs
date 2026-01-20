using Microsoft.AspNetCore.Mvc;

namespace ExoMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
