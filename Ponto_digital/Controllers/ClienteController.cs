using Microsoft.AspNetCore.Mvc;

namespace Ponto_digital.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index(){
            ViewData["ViewName"] = "Login";
            return View("Login");
        }
        public IActionResult Cadastro(){
            ViewData["ViewName"] = "Cadastro";
            return View();
        }
    }
}