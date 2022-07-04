using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCadastroEmail
{
    internal class Pessoa
    {
        public string nome;
        public string email;

        public Pessoa(string n, string e)
        {
            nome = n;
            email = e;
        }
    }
}
