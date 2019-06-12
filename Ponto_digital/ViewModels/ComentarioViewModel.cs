using System.Collections.Generic;
using Ponto_digital.Models;

namespace Ponto_digital.ViewModels
{
    public class ComentarioViewModel
    {
        public List<ComentarioModel> ListaDeComentariosAprovados = new List<ComentarioModel>();
        public List<ComentarioModel> ListaDeComentariosReprovados = new List<ComentarioModel>();
        public List<ComentarioModel> ListaDeComentariosEmEspera = new List<ComentarioModel>();
        public ComentarioViewModel(){

        }
        public ComentarioViewModel(List<ComentarioModel> listaDeComentariosAprovados, List<ComentarioModel> listaDeComentariosReprovados, List<ComentarioModel> listaDeComentariosEmEspera){
            ListaDeComentariosAprovados = listaDeComentariosAprovados;
            ListaDeComentariosReprovados = listaDeComentariosReprovados;
            ListaDeComentariosEmEspera = listaDeComentariosEmEspera;
        }
    }
}