using System.IO;
using Ponto_digital.Models;

namespace Ponto_digital.Repositories
{
    public class ComentarioRepository
    {
        const string PATH = "Database/Comentarios.csv";
        public static void InserirComentario(ComentarioModel comentario){
            if(!File.Exists(PATH)){
                File.Create(PATH);
            }
            File.AppendAllText(PATH,$"{comentario.Cliente.Email};{comentario.Conteudo}\n");
        }
    }
}