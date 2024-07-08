using Microsoft.AspNetCore.Mvc;

namespace Microondas_Digital.Controllers
{
    public class Sobre : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
