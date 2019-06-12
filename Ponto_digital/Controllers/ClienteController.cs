using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_digital.Models;
using Ponto_digital.Repositories;
using Ponto_digital.Utils;

namespace Ponto_digital.Controllers {
    public class ClienteController : Controller {
        public IActionResult Index () {
            ViewData["ViewName"] = "Login";
            return View ("Login");
        }
        public IActionResult Cadastro () {
            ViewData["ViewName"] = "Cadastro";
            return View ();
        }

        [HttpPost]
        public IActionResult CadastrarCliente (IFormCollection form) {
            if (!form["senha"].Equals (form["confirmarSenha"])) {
                return View ("Cadastro");
                // TODO: TELA DE SENHAS NÃO COMPATÍVEIS

            } else {
                var cliente = new ClienteModel (
                    nome: form["primeiroNome"] + " " + form["sobrenome"],
                    nomeEmpresa: form["empresa"],
                    telefone: form["telefone"],
                    email: form["email"],
                    senha: form["senha"],
                    dataDeNascimento: DateTime.Parse (form["dataDeNascimento"])
                );
                ClienteRepository.Inserir (cliente);
                ViewData["ViewName"] = "Login";
                return View ("Login");
                // TODO: TELA DE SUCESSO
            }
        }

        [HttpPost]
        public IActionResult FazerLogin (IFormCollection form) {
            List<ClienteModel> listaDeClientes = ClienteRepository.Listar ();
            foreach (var cliente in listaDeClientes) {
                if (cliente == null) {
                    ViewData["ViewName"] = "Login";
                    return View ("Login");
                }
                if (!form["email"].Equals ("admin@agoravai.com") && !form["senha"].Equals ("admin")) {
                    if (form["email"].Equals (cliente.Email) && form["senha"].Equals (cliente.Senha)) {
                        HttpContext.Session.SetString (ConstantesUtils.SESSION_CLIENTE, cliente.Nome);
                        HttpContext.Session.SetString (ConstantesUtils.SESSION_EMAIL, cliente.Email);

                        return RedirectToAction ("Index", "Home");
                    }
                } else {
                    HttpContext.Session.SetString (ConstantesUtils.SESSION_ADMINISTRADOR, "ADMINISTRADOR");
                    HttpContext.Session.SetString (ConstantesUtils.SESSION_CLIENTE, "Administrador");
                    return RedirectToAction ("Index", "Home"); //TODO TELA DE ADMINISTRADOR
                }
            }
            ViewData["Mensagem"] = "Email ou senha incorretos.";
            Console.Write ("Passou");
            ViewData["ViewName"] = "Login";
            return View ("Login");
        }
        public IActionResult Logout () {
            HttpContext.Session.Remove (ConstantesUtils.SESSION_CLIENTE);
            if (!String.IsNullOrEmpty (HttpContext.Session.GetString (ConstantesUtils.SESSION_ADMINISTRADOR))) {
                HttpContext.Session.Remove (ConstantesUtils.SESSION_ADMINISTRADOR);
            }
            HttpContext.Session.Remove (ConstantesUtils.SESSION_EMAIL);
            return RedirectToAction ("Index", "Home");
        }
    }
}