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
            cliente.Id = ListaDeClientes == null ? 1 : ListaDeClientes.Count + 1;

            File.AppendAllText(CLIENTES_PATH, $"\n{cliente.Id};{cliente.Nome};{cliente.Email};{cliente.Senha};{cliente.Telefone};{cliente.NomeEmpresa};{cliente.DataDeNascimento}");
        }
        public static List<ClienteModel> Listar(){
            ListaDeClientes.Clear();
            var listaInteira = File.ReadAllLines(CLIENTES_PATH);
            foreach (var linha in listaInteira)
            {
                if(linha != null){
                var dados = linha.Split(";");
                if(int.Parse(dados[0]) == 1){
                    var cliente = new ClienteModel(
                        id:int.Parse(dados[0]),
                        nome:dados[1],
                        email:dados[2],
                        senha:dados[3]
                    );
                    ListaDeClientes.Add(cliente);
                }
                else{
                var cliente = new ClienteModel(
                    id:int.Parse(dados[0]),
                    nome:dados[1],
                    telefone:dados[4],
                    nomeEmpresa:dados[5],
                    email:dados[2],
                    senha:dados[3],
                    dataDeNascimento: DateTime.Parse(dados[6])
                );
                ListaDeClientes.Add(cliente);
                }
                }
            }
            return ListaDeClientes;
        }
        public static ClienteModel ObterClientePor(string email){
            ListaDeClientes = Listar();

            foreach (var item in ListaDeClientes)
            {
                if(item.Email.Equals(email)){
                    return item;
                }   
            }
            return null;
        }
        
    }
}