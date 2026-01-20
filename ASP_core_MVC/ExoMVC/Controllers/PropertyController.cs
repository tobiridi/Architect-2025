using ExoMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ExoMVC.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Property()
        {
            return View(PropertyViewModel.FakeProperties());
        }

        public IActionResult PropertyDetails(int id)
        {
            List<PropertyViewModel> list = PropertyViewModel.FakeProperties().Where(p => p.ID == id).ToList();
            return View(list);
        }

    }
}
