using System;
namespace Ponto_digital.Models
{
    public class ClienteModel
    {
        public int Id{get;set;}
        public bool Administrador{get;set;}
        public string Nome{get;set;}
        public string NomeEmpresa{get;set;}
        public string Telefone{get;set;}
        public string Email{get;set;}
        public string Senha{get;set;}
        public DateTime DataDeNascimento{get;set;} 
        public ClienteModel(){

        }
        // Construtor para cadastro
        public ClienteModel(string nome, string nomeEmpresa, string telefone, string email, string senha, DateTime dataDeNascimento){
            Nome = nome;
            NomeEmpresa = nomeEmpresa;
            Telefone = telefone;
            Email = email;
            Senha = senha;
            DataDeNascimento = dataDeNascimento;
        }
        // Construtor para os métodos Listar
        public ClienteModel(int id,string nome, string nomeEmpresa, string telefone, string email, string senha, DateTime dataDeNascimento){
            Id = id;
            Nome = nome;
            NomeEmpresa = nomeEmpresa;
            Telefone = telefone;
            Email = email;
            Senha = senha;
            DataDeNascimento = dataDeNascimento;
        }
    }
}