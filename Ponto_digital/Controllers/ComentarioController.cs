using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_digital.Models;
using Ponto_digital.Repositories;
using Ponto_digital.Utils;

namespace Ponto_digital.Controllers
{
    public class ComentarioController : Controller
    {
        public IActionResult CriarComentário(IFormCollection form){
            var comentario = new ComentarioModel(
                cliente:ClienteRepository.ObterClientePor(HttpContext.Session.GetString(ConstantesUtils.SESSION_EMAIL)),
                conteudo:form["conteudo"]
            );
            ComentarioRepository.InserirComentario(comentario);
            return RedirectToAction("Atendimento", "Home");
        }
    }
}