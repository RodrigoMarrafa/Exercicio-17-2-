using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_17__2_
{
    internal class Utilizador
    {
        public string Nome = "";
        public string Email = "";
        public string Password = "";
        public Utilizador(string nome, string email, string password)
        {
            Nome=nome;
            Email=email;
            Password=password;
        }
        public static List<Utilizador> listaUtilizadores = new List<Utilizador>();
        public static void AdicionarRegisto(string Nome, string Email, string Password)
        {
            Utilizador novoUtilizador = new Utilizador(Nome,Email,Password);
            listaUtilizadores.Add(novoUtilizador);
        }
    }
}
