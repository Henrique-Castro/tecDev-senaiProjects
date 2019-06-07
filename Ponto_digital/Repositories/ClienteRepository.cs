using System;
using System.Collections.Generic;
using System.IO;
using Ponto_digital.Models;

namespace Ponto_digital.Repositories
{
    public class ClienteRepository
    {
        private static List<ClienteModel> ListaDeClientes = new List<ClienteModel>();
        const string CLIENTES_PATH = "Database/Clientes.csv" ;

        public static void Inserir(ClienteModel cliente){
            if(!File.Exists(CLIENTES_PATH)){
                File.Create(CLIENTES_PATH);
            }
            ListaDeClientes = Listar();
            // ListaDeClientes == null ? cliente.Id = 1 : cliente.Id = ListaDeClientes.Count + 1;
            if(ListaDeClientes == null){
                cliente.Id = 1;
            }else{
                cliente.Id = ListaDeClientes.Count + 1;
            }
            File.AppendAllText(CLIENTES_PATH, $"{cliente.Id};{cliente.Nome};{cliente.Telefone};{cliente.NomeEmpresa};{cliente.Email};{cliente.Senha};{cliente.DataDeNascimento}");
        }
        public static List<ClienteModel> Listar(){
            ListaDeClientes.Clear();
            var listaInteira = File.ReadAllLines(CLIENTES_PATH);
            foreach (var linha in listaInteira)
            {
                if(linha != null){
                var dados = linha.Split(";");
                var cliente = new ClienteModel(
                    id:int.Parse(dados[0]),
                    nome:dados[1],
                    telefone:dados[2],
                    nomeEmpresa:dados[3],
                    email:dados[4],
                    senha:dados[5],
                    dataDeNascimento: DateTime.ParseExact(dados[6],"dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture)
                );
                ListaDeClientes.Add(cliente);
                }
            }
            return ListaDeClientes;
        }
        
    }
}