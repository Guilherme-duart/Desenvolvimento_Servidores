using ConsoleApp_Manha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Desenvolvimento_de_Servidores
{
    public class cliente
    {
        private int Id;
        private string Nome;
        private string Telefone;
        private Endereco Endereco;

        public cliente(int id, string nome, string telefone , Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;


        }

       public int getId()
        {
            return Id;
        }

        public string getNome()
        {
            return Nome;
        }

        public string getTelefone()
        {
            return Telefone;
        }

        public Endereco getEndereco()
        {
            return Endereco;
        }

        public void setNome(string nome)
        {
            Nome = nome;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }

        public void setEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

    }

  
}
