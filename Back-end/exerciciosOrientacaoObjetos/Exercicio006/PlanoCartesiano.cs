using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio006
{
    internal class PlanoCartesiano
    {
        private int posicaoX;
        private int posicaoY;

        public PlanoCartesiano(int posicaoX, int posicaoY)
        {
            this.PosicaoX = posicaoX;
            this.PosicaoY = posicaoY;
        }

        public int PosicaoX { get => posicaoX; set => posicaoX = value; }
        public int PosicaoY { get => posicaoY; set => posicaoY = value; }

        public void exibeDados()
        {
            Console.WriteLine("Dados do ponto no Plano Cartesiano: \n" +
                              "[1] - Posição X: {0}\n" +
                              "[2] - Posição Y: {1}\n",this.PosicaoX, this.PosicaoY);
        }
        
        public static void exibeItensLista(List<PlanoCartesiano> lista)
        {
            Console.WriteLine("Coordenadas presente na lista: ");
            foreach (PlanoCartesiano p in lista)
            {
                Console.WriteLine("Coordenadas do Plano Cartesiano: ({0},{1}).", p.PosicaoX, p.PosicaoY);
            }
        }
    }
}
