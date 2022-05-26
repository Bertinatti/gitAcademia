using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio004
{
    internal class Asteroide
    {
        private int posicaoX;
        private int posicaoY;
        private int tamanho;
        private int velocidade;
        private int energia;

        public int PosicaoX { get => posicaoX; set => posicaoX = value; }
        public int PosicaoY { get => posicaoY; set => posicaoY = value; }
        public int Tamanho { get => tamanho; set => tamanho = value; }
        public int Velocidade { get => velocidade; set => velocidade = value; }
        public int Energia { get => energia; set => energia = value; }

        public Asteroide()
        {

        }
        public Asteroide(int posicaoX, int posicaoY)
        {
            this.posicaoX = posicaoX;
            this.posicaoY = posicaoY;
        }

        public Asteroide(int posicaoX, int posicaoY, int tamanho, int velocidade, int energia)
        {
            this.posicaoX = posicaoX;
            this.posicaoY = posicaoY;
            this.tamanho = tamanho;
            this.velocidade = velocidade;
            this.energia = energia;
        }

        public static void ExibirItensLista(List<Asteroide> lista)
        {
            Console.WriteLine("Os dados cadastrados na lista de asteróide são: ");
            Console.WriteLine("==============================================================================\n" +
                              "|   POSIÇÃO X   |   POSIÇÃO Y   |   TAMANHO   |   VELOCIDADE   |   ENERGIA   |");

            foreach (Asteroide a in lista)
            {
                Console.WriteLine("|      {0:00}       |      {1:00}       |     {2:00}      |       {3:00}       |     {4:00}      |", a.PosicaoX, a.PosicaoY, a.Tamanho, a.Velocidade, a.Energia);
            }

            Console.WriteLine("==============================================================================\n");

        }
    }
}
