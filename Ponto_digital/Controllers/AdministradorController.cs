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
        public IActionResult AprovarComentario (int idComentario) {
            var comentarioViewModel = ComentarioRepository.ClassificarComentarios ();
            ComentarioRepository.EditarSituacao (ComentarioRepository.ObterComentarioPorId (idComentario), "Aprovado");
            ViewData["ViewName"] = "ControlPanel";
            ViewBag.User = HttpContext.Session.GetString (ConstantesUtils.SESSION_CLIENTE);
            ViewBag.Adm = HttpContext.Session.GetString (ConstantesUtils.SESSION_ADMINISTRADOR);
            return View ("ControlPanel");
        }
    }
}