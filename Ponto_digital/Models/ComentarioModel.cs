using System;

namespace Ponto_digital.Models {
    public class ComentarioModel {
        public int IdComentario {get;set;}
        public ClienteModel Cliente { get; set; }
        public string Conteudo { get; set; }
        public string Situacao{get;set;}
        public DateTime Data{get;set;}

        public ComentarioModel(ClienteModel cliente, string conteudo){
            Cliente = cliente;
            Conteudo = conteudo;
            Situacao = "Aguardando";
            Data = DateTime.Now;
            //TODO: A BOOLEANA APROVADO DEVE SER MUDADA APENAS PELO ADM E ENTÃO MOSTRADA
        }
        public ComentarioModel(int idComentario, ClienteModel cliente, string conteudo, string situacao, DateTime data){
            IdComentario = idComentario;
            Cliente = cliente;
            Conteudo = conteudo;
            Situacao = situacao;
            Data = data;
        }
    }
}