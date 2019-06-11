namespace Ponto_digital.Models {
    public class ComentarioModel {
        public ClienteModel Cliente { get; set; }
        public string Conteudo { get; set; }

        public ComentarioModel(ClienteModel cliente, string conteudo){
            Cliente = cliente;
            Conteudo = conteudo;
        }
    }
}