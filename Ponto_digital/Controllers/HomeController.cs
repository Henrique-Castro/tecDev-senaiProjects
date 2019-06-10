using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_digital.Utils;

namespace Ponto_digital.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(){
            ViewData["ViewName"] = "Home";
            ViewData["User"] = HttpContext.Session.GetString(ConstantesUtils.SESSION_CLIENTE);
            ViewData["Tipo"] = HttpContext.Session.GetString(ConstantesUtils.SESSION_ADMINISTRADOR);
            return View();
        }
        public IActionResult Atendimento(){
            ViewData["ViewName"] = "Atendimento";
            ViewData["Tipo"] = HttpContext.Session.GetString(ConstantesUtils.SESSION_ADMINISTRADOR);
            return View();
        }
        public IActionResult Sobre(){
            ViewData["ViewName"] = "Sobre";
            ViewData["Tipo"] = HttpContext.Session.GetString(ConstantesUtils.SESSION_ADMINISTRADOR);
            return View();
        }
    }
}