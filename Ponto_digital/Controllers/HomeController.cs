using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_digital.Models;
using Ponto_digital.Repositories;
using Ponto_digital.Utils;

namespace Ponto_digital.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(){
            ViewData["ViewName"] = "Home";
            ViewBag.User = HttpContext.Session.GetString(ConstantesUtils.SESSION_CLIENTE);
            ViewBag.Adm = HttpContext.Session.GetString(ConstantesUtils.SESSION_ADMINISTRADOR);
            return View();
        }
        public IActionResult Atendimento(){
            ViewData["ViewName"] = "Atendimento";
            ViewBag.User = HttpContext.Session.GetString(ConstantesUtils.SESSION_CLIENTE);
            ViewBag.Adm = HttpContext.Session.GetString(ConstantesUtils.SESSION_ADMINISTRADOR);

            return View(ComentarioRepository.ClassificarComentarios());
        }
        public IActionResult Sobre(){
            ViewData["ViewName"] = "Sobre";
            ViewBag.User = HttpContext.Session.GetString(ConstantesUtils.SESSION_CLIENTE);
            ViewBag.Adm = HttpContext.Session.GetString(ConstantesUtils.SESSION_ADMINISTRADOR);
            return View();
        }
        public IActionResult CriarComentario (IFormCollection form) {
            var novoComentario = new ComentarioModel (
                cliente: ClienteRepository.ObterClientePor (HttpContext.Session.GetString (ConstantesUtils.SESSION_EMAIL)),
                conteudo: form["conteudo"]
            );
            ComentarioRepository.InserirComentario (novoComentario);
            ViewData["ViewName"] = "Atendimento";
            ViewBag.User = HttpContext.Session.GetString(ConstantesUtils.SESSION_CLIENTE);
            ViewBag.Adm = HttpContext.Session.GetString(ConstantesUtils.SESSION_ADMINISTRADOR);
            return View("Atendimento",ComentarioRepository.ClassificarComentarios());
        }
    }
}