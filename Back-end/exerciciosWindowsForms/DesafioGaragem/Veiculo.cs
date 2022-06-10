using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGaragem
{
    internal class Veiculo
    {
        private string placaVeiculo;
        private DateTime dataEntrada;
        private DateTime horaEntrada;
        private int tempoPermanencia;
        private double valorCobrado;

        public Veiculo(string placaVeiculo, DateTime dataEntrada, DateTime horaEntrada)
        {
            this.placaVeiculo = placaVeiculo;
            this.dataEntrada = dataEntrada;
            this.horaEntrada = horaEntrada;
        }
        public Veiculo(string placaVeiculo, int tempoPermanencia, double valorCobrado)
        {
            this.placaVeiculo = placaVeiculo;
            this.tempoPermanencia = tempoPermanencia;
            this.valorCobrado = valorCobrado;
        }

        public Veiculo(string placaVeiculo, DateTime dataEntrada, DateTime horaEntrada, int tempoPermanencia, double valorCobrado)
        {
            this.placaVeiculo = placaVeiculo;
            this.dataEntrada = dataEntrada;
            this.horaEntrada = horaEntrada;
            this.tempoPermanencia = tempoPermanencia;
            this.valorCobrado = valorCobrado;
        }

        public string PlacaVeiculo { get => placaVeiculo; set => placaVeiculo = value; }
        public DateTime DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public int TempoPermanencia { get => tempoPermanencia; set => tempoPermanencia = value; }
        public double ValorCobrado { get => valorCobrado; set => valorCobrado = value; }
    }
}
