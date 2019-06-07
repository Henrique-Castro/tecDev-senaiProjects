using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_digital.Models;
using Ponto_digital.Repositories;

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
        public IActionResult CadastrarCliente(IFormCollection form){
            if(form["senha"].Equals(form["confirmarSenha"])){
            var cliente = new ClienteModel(
                nome:form["primeiroNome"] + form["sobrenome"],
                nomeEmpresa:form["empresa"],
                telefone:form["telefone"],
                email:form["email"],
                senha:form["senha"],
                dataDeNascimento:DateTime.ParseExact(form["dataDeNascimento"],"dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture)
            );
            ClienteRepository.Inserir(cliente);
            // TODO: TELA DE SUCESSO
            return View();
            }else{
                // TODO: TELA DE SENHAS NÃO COMPATÍVEIS
                return View();
            }
        }
        public IActionResult FazerLogin(IFormCollection form){
            return View();
        }
    }
}