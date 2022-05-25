using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio001
{
    internal class Personagem
    {
        private string nome;
        public string Nome { get { return nome; } set { nome = value; } }

        private int poder;
        public int Poder { get => poder; set => poder = value; }

        // construtor sem parâmetro
        public Personagem()
        {
            
        }

        // sobrecarga do construtor com dois parâmetros - nome e poder (0 a 10)
        public Personagem(string n, int p)
        {
            this.Nome = n;
            this.Poder = p;
        }
        
        public void ExibirDados()
        {
            Console.WriteLine("=============== PERSONAGEM ===============\n" +
                              "Nome: {0}\n" +
                              "Poder: {1}\n" +
                              "==========================================\n", this.Nome, this.Poder);
        }
    }
}
