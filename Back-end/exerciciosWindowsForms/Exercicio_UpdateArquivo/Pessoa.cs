using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_UpdateArquivo
{
    internal class Pessoa
    {
        private string nomeCompleto;
        private string email;

        public Pessoa(string nomeCompleto, string email)
        {
            this.nomeCompleto = nomeCompleto;
            this.email = email;
        }

        public string NomeCompleto { get => nomeCompleto; set => nomeCompleto = value; }
        public string Email { get => email; set => email = value; }

        /// <summary>
        /// Método para verificar se o nome digitado já foi cadastrado.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static bool jaCadastrado(string nome, List<Pessoa> lista)
        {
            foreach (Pessoa i in lista)
            {
                if(i.NomeCompleto.Equals(nome))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Método para localizar o índice do usuário na lista.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static int localiza(string nome, List<Pessoa> lista)
        {
            foreach (Pessoa i in lista)
            {
                if (i.NomeCompleto.Equals(nome))
                {
                    return lista.IndexOf(i);
                }
            }
            return -27;
        }
    }
}
