using Microsoft.AspNetCore.Mvc;
using System.Data.Common;

namespace ExoMVC.Controllers
{
    public class PatientController : Controller
    {
        private readonly DbConnection _DbConnection;
        //avoir un constructeur qui a le service, utilise l'injection de dépendance (idéalement le mettre dans une classe "service")
        public PatientController(DbConnection dbConnection)
        {
            _DbConnection = dbConnection;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
