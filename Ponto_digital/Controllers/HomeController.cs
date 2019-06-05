using Microsoft.AspNetCore.Mvc;

namespace Ponto_digital.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            ViewData["ViewName"] = "Home";
            return View();
        }
        public IActionResult Atendimento(){
            ViewData["ViewName"] = "Atendimento";
            return View();
        }
        public IActionResult Sobre(){
            ViewData["ViewName"] = "Sobre";
            return View();
        }
    }
}