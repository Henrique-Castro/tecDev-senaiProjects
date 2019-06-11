using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_digital.Utils;

namespace Ponto_digital.Controllers
{
    public class AdministradorController : Controller
    {
        public IActionResult Index(){
            ViewData["ViewName"] = "ControlPanel";
            ViewBag.User = HttpContext.Session.GetString(ConstantesUtils.SESSION_CLIENTE);
            ViewBag.Adm = HttpContext.Session.GetString(ConstantesUtils.SESSION_ADMINISTRADOR);
            return View("ControlPanel");
        }
    }
}