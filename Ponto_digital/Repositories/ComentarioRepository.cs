using System;
using System.Collections.Generic;
using System.IO;
using Ponto_digital.Models;
using Ponto_digital.ViewModels;

namespace Ponto_digital.Repositories {
    public class ComentarioRepository {
        const string PATH = "Database/Comentarios.csv";
        public static List<ComentarioModel> ListaDeComentarios = new List<ComentarioModel> ();
        public static void InserirComentario (ComentarioModel comentario) {
            if (!File.Exists (PATH)) {
                File.Create (PATH);
            }
            if (ListarComentarios () == null) {
                comentario.IdComentario = 0;
            } else {
                comentario.IdComentario = ListarComentarios ().Count + 1;
            }
            File.AppendAllText (PATH, $"{comentario.IdComentario};{comentario.Cliente.Email};{comentario.Conteudo};{comentario.Situacao};{comentario.Data}\n");

        }
        public static List<ComentarioModel> ListarComentarios () {
            ListaDeComentarios.Clear ();
            if (File.Exists (PATH) && File.ReadAllLines (PATH) != null) {
                foreach (var item in File.ReadAllLines (PATH)) {
                    var dados = item.Split (";");
                    var comentario = new ComentarioModel (
                        idComentario: int.Parse (dados[0]),
                        cliente: ClienteRepository.ObterClientePor (dados[1]),
                        conteudo: dados[2],
                        situacao: dados[3],
                        data: DateTime.Parse (dados[4])
                    );
                    ListaDeComentarios.Add (comentario);
                }
                return ListaDeComentarios;
            } else {
                return null;
            }
        }

        public static ComentarioViewModel ClassificarComentarios () {
            List<ComentarioModel> listaDeComentarios = ComentarioRepository.ListarComentarios ();
            var comentarioViewModel = new ComentarioViewModel ();
            foreach (var comentario in listaDeComentarios) {
                switch (comentario.Situacao) {
                    case "Aguardando":
                        comentarioViewModel.ListaDeComentariosEmEspera.Add (comentario);
                        break;
                    case "Aprovado":
                        comentarioViewModel.ListaDeComentariosAprovados.Add (comentario);
                        break;
                    case "Reprovado":
                        comentarioViewModel.ListaDeComentariosReprovados.Add (comentario);
                        break;
                    default:
                        comentarioViewModel.ListaDeComentariosEmEspera.Add (comentario);
                        break;
                }
                comentarioViewModel.ListaDeTodosComentarios.Add(comentario);
            }
            return comentarioViewModel;
        }
        public static ComentarioModel ObterComentarioPorId (int id) {
            foreach (var comentario in ListarComentarios ()) {
                if (comentario.IdComentario == id && comentario != null) {
                    return comentario;
                }
            }
            return null;
        }
        public static void EditarSituacao (ComentarioModel comentario, string situacao) {
            List<ComentarioModel> novaListaDeComentarios = new List<ComentarioModel> ();
            foreach (var item in ListarComentarios ()) {
                if (item.IdComentario == comentario.IdComentario) {
                    item.Situacao = situacao;
                    novaListaDeComentarios.Add (item);
                } else {
                    novaListaDeComentarios.Add (item);
                }
            }

            for (int i = 0; i < novaListaDeComentarios.Count; i++) {
                if (i == 0) {
                    File.WriteAllText (PATH, $"{novaListaDeComentarios[i].IdComentario};{novaListaDeComentarios[i].Cliente.Email};{novaListaDeComentarios[i].Conteudo};{novaListaDeComentarios[i].Situacao};{novaListaDeComentarios[i].Data}\n");
                } else {
                    File.AppendAllText (PATH, $"{novaListaDeComentarios[i].IdComentario};{novaListaDeComentarios[i].Cliente.Email};{novaListaDeComentarios[i].Conteudo};{novaListaDeComentarios[i].Situacao};{novaListaDeComentarios[i].Data}\n");
                }
            }
        }
    }
}