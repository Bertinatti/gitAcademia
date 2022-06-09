using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio001
{
    internal class Carro
    {
        private string modelo;
        private string fabricante;
        private bool ar;
        private bool dh;
        private bool abs;
        private bool airbag;
        private bool ve;
        private int portas;

        public Carro(string modelo, string fabricante, bool ar, bool dh, bool abs, bool airbag, bool ve, int portas)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.ar = ar;
            this.dh = dh;
            this.abs = abs;
            this.airbag = airbag;
            this.ve = ve;
            this.portas = portas;
        }

        public void MostrarDadosCarro()
        {
            MessageBox.Show("Modelo do carro: " + this.modelo +
                            "\nFabricante do carro: " + this.fabricante + 
                            "\nAr-condicionado: " + this.ar + 
                            "\nDireção-hidráulica: " + this.dh +
                            "\nAbs: " + this.abs +
                            "\nAirbag: " + this.airbag +
                            "\nVidro-elétrico: " + this.ve +
                            "\nNúmero de portas: " + this.portas);
        }

        public string Modelo { get => modelo; set => modelo = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public bool Ar { get => ar; set => ar = value; }
        public bool Dh { get => dh; set => dh = value; }
        public bool Abs { get => abs; set => abs = value; }
        public bool Airbag { get => airbag; set => airbag = value; }
        public bool Ve { get => ve; set => ve = value; }
        public int Portas { get => portas; set => portas = value; }
    }
}
