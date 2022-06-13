using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGaragem
{
    internal class Garagem
    {
        private int vagas;
        private double precoCobrado;

        public Garagem(int vagas, double precoCobrado)
        {
            this.vagas = vagas;
            this.precoCobrado = precoCobrado;
        }

        public int Vagas { get => vagas; set => vagas = value; }
        public double PrecoCobrado { get => precoCobrado; set => precoCobrado = value; }
    }
}
