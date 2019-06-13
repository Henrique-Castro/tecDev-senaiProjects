using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_digital.Repositories;
using Ponto_digital.Utils;
using Ponto_digital.ViewModels;

namespace Ponto_digital.Controllers {
    public class AdministradorController : Controller {
        public IActionResult Index () {
            ViewData["ViewName"] = "ControlPanel";
            ViewBag.User = HttpContext.Session.GetString (ConstantesUtils.SESSION_CLIENTE);
            ViewBag.Adm = HttpContext.Session.GetString (ConstantesUtils.SESSION_ADMINISTRADOR);
            return View ("ControlPanel", ComentarioRepository.ClassificarComentarios ());
        }
        [HttpGet]
        public IActionResult AlterarComentario (int idComentario, string situacao) {
            ComentarioRepository.EditarSituacao (ComentarioRepository.ObterComentarioPorId (idComentario), situacao);
            ViewData["ViewName"] = "ControlPanel";
            ViewBag.User = HttpContext.Session.GetString (ConstantesUtils.SESSION_CLIENTE);
            ViewBag.Adm = HttpContext.Session.GetString (ConstantesUtils.SESSION_ADMINISTRADOR);
            return View ("ControlPanel", ComentarioRepository.ClassificarComentarios ());
        }
    }
}