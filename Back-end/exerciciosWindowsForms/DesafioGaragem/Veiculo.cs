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
        private string dataEntrada;
        private string horaEntrada;
        private int tempoPermanencia;
        private double valorCobrado;
        /// <summary>
        /// Método construtor com 3 parâmetros de entrada.
        /// </summary>
        /// <param name="placaVeiculo">Placa do veículo.</param>
        /// <param name="dataEntrada">Data da entrada do veículo.</param>
        /// <param name="horaEntrada">Hora da entrada do veículo.</param>
        public Veiculo(string placaVeiculo, string dataEntrada, string horaEntrada)
        {
            this.placaVeiculo = placaVeiculo;
            this.dataEntrada = dataEntrada;
            this.horaEntrada = horaEntrada;
        }
        /// <summary>
        /// Método construtor com 3 parâmetros de entrada.
        /// </summary>
        /// <param name="placaVeiculo">Placa do veículo</param>
        /// <param name="tempoPermanencia">Tempo de permanência do veículo, em minutos.</param>
        /// <param name="valorCobrado">Valor cobrado pela estadia.</param>
        public Veiculo(string placaVeiculo, int tempoPermanencia, double valorCobrado)
        {
            this.placaVeiculo = placaVeiculo;
            this.tempoPermanencia = tempoPermanencia;
            this.valorCobrado = valorCobrado;
        }
        /// <summary>
        /// Método construtor com 5 parâmetros de entrada.
        /// </summary>
        /// <param name="placaVeiculo">Placa do veículo.</param>
        /// <param name="dataEntrada">Data de entrada do veículo.</param>
        /// <param name="horaEntrada">Hora da entrada do veículo.</param>
        /// <param name="tempoPermanencia">Tempo de permanência do veículo, em minutos.</param>
        /// <param name="valorCobrado">Valor cobrado pela estadia.</param>
        public Veiculo(string placaVeiculo, string dataEntrada, string horaEntrada, int tempoPermanencia, double valorCobrado)
        {
            this.placaVeiculo = placaVeiculo;
            this.dataEntrada = dataEntrada;
            this.horaEntrada = horaEntrada;
            this.tempoPermanencia = tempoPermanencia;
            this.valorCobrado = valorCobrado;
        }
        /// <summary>
        /// Método para verificar se o carro se encontra na garagem.
        /// </summary>
        /// <param name="placa">Placa do veículo.</param>
        /// <param name="lista">Lista com os veículos que estão no sistema.</param>
        /// <returns>Retorna true caso o veículo já esteja no sistema.</returns>
        public static bool verificaGaragem(string placa, List<Veiculo> lista)
        {
            foreach (Veiculo i in lista)
            {
                if (i.placaVeiculo.Equals(placa))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Método para verificar se há vagas na garagem.
        /// </summary>
        /// <param name="lista">Lista com os veículos que estão no sistema.</param>
        /// <returns>Retorna true caso haja vagas.</returns>
        public static bool verificaVagasGaragem(List<Veiculo> lista)
        {
            if (lista.Count() < 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Método para verificar se está dentro do horario de funcionamento.
        /// </summary>
        /// <param name="horaMinuto">Hora digitada pelo usuário.</param>
        /// <returns>Retorna true caso esteja dentro do horario de funcionamento.</returns>
        public static bool verificaHoraFuncionamento(string horaMinuto)
        {
            string[] horaMinutoSplit = horaMinuto.Split(':');
            int hora = int.Parse(horaMinutoSplit[0]);
            int minuto = int.Parse(horaMinutoSplit[1]);
            TimeSpan entrada = new TimeSpan(7, 0, 0);
            TimeSpan saida = new TimeSpan(20, 0, 0);
            TimeSpan horaMinutoTS = new TimeSpan(hora, minuto, 0);
            if (horaMinutoTS >= entrada && horaMinutoTS <= saida)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        ///  Método para validar a hora digitada pelo usuário.
        /// </summary>
        /// <param name="horaMinuto">Hora digitada pelo usuário.</param>
        /// <returns>Retorna true caso o formato da hora esteja no padrão correto.</returns>
        public static bool validaHora(string horaMinuto)
        {
            string[] horaMinutoSplit = horaMinuto.Split(':');
            int hora = int.Parse(horaMinutoSplit[0]);
            int minuto = int.Parse(horaMinutoSplit[1]);
            if (hora >= 00 && hora <= 24 && minuto >= 00 && minuto <= 59)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Método para realizar a cobrança pela estadia do veículo.
        /// </summary>
        /// <param name="horaSaida">Hora digitada pelo usuário.</param>
        public void realizarCobranca(string horaSaida)
        {
            string[] vetorDados = horaEntrada.Split(':');
            int hora = int.Parse(vetorDados[0]);
            int minutos = int.Parse(vetorDados[1]);
            int entrada = hora * 60 + minutos;

            vetorDados = horaSaida.Split(':');
            hora = int.Parse(vetorDados[0]);
            minutos = int.Parse(vetorDados[1]);
            int saida = hora * 60 + minutos;

            this.TempoPermanencia = saida - entrada;
            double horasCobranca = (double) this.TempoPermanencia / 60;
            int tempo = (int) Math.Ceiling(horasCobranca);
            this.ValorCobrado = tempo * 5;
        }

        public string PlacaVeiculo { get => placaVeiculo; set => placaVeiculo = value; }
        public string DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public string HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public int TempoPermanencia { get => tempoPermanencia; set => tempoPermanencia = value; }
        public double ValorCobrado { get => valorCobrado; set => valorCobrado = value; }
        /// <summary>
        /// Método abstrato que gera a data atual.
        /// </summary>
        /// <returns>Retorna a data atual.</returns>
        public static string gerarData()
        {
            DateTime dateTime = DateTime.Now;
            string dataFormatada = dateTime.ToString("dd/MM/yyyy hh:mm:ss");
            string[] vetorDados = dataFormatada.Split(' ');
            return vetorDados[0];
        }
        /// <summary>
        /// Método para capturar o índice do veículo na lista.
        /// </summary>
        /// <param name="placa">Placa do veículo para procura na lista.</param>
        /// <param name="lista">Lista com os veículos.</param>
        /// <returns>Retorna um índice inteiro da posição do veículo na lista.</returns>
        public static int localizaNaLista(string placa, List<Veiculo> lista)
        {
            foreach(Veiculo v in lista)
            {
                if (v.placaVeiculo.Equals(placa))
                {
                    return lista.IndexOf(v);
                }
            }
            return -27;
        }
    }
}
