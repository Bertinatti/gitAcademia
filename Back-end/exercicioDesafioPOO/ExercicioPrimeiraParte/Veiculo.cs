using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPrimeiraParte
{
    internal class Veiculo
    {
        // atributos
        private string placa;
        private DateTime dataHoraEntrada;

        // método construtor 
        public Veiculo(string placa)
        {
            this.placa = placa;
            this.dataHoraEntrada = DateTime.Now;
        }

        // método construtor sobrecarga 1
        public Veiculo(string placa, DateTime dataHoraEntrada)
        {
            this.placa = placa;
            this.dataHoraEntrada = dataHoraEntrada;
        }

        // métodos getters e setters
        public string Placa { get => placa; set => placa = value; }
        public DateTime DataHoraEntrada { get => dataHoraEntrada; set => dataHoraEntrada = value; }
    }
}
