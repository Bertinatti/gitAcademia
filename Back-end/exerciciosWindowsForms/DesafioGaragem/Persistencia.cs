using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGaragem
{
    internal class Persistencia
    {
        /// <summary>
        /// Método para ler os dados persistidos no arquivo, com o histórico de todos os veículos que estão usando o sistema.
        /// </summary>
        /// <param name="lista">Lista com os veículos que estão usando o sistema.</param>
        public static void lerArquivoVeiculosEntrada(List<Veiculo> lista)
        {
            string nomeArquivo = "veiculosEntrada.dat";

            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo);

                string linha;
                string[] linhaSplit;

                do
                {
                    linha = leitor.ReadLine();

                    if (linha != null && linha != "")
                    {
                        linhaSplit = linha.Split(';');

                        Veiculo veiculo = new Veiculo(linhaSplit[0], linhaSplit[1], linhaSplit[2]);

                        lista.Add(veiculo);

                    }

                } while (!leitor.EndOfStream);

                leitor.Close();

            }

            catch (IOException e)
            {
                Console.WriteLine("Erro ao ler arquivo: " + e.Message);
            }

            StreamWriter escritor = new StreamWriter(nomeArquivo, true);
            escritor.Close();
        }
        /// <summary>
        /// Método para ler os dados persistidos no arquivo, com o histórico de todos os veículos que utilizaram o sistema.
        /// </summary>
        /// <param name="lista">Lista com os veículos que usaram o sistema.</param>
        public static void lerArquivoVeiculosSaida(List<Veiculo> lista)
        {
            string nomeArquivo = "veiculosSaida.dat";

            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo);

                string linha;
                string[] linhaSplit;

                do
                {
                    linha = leitor.ReadLine();

                    if (linha != null && linha != "")
                    {
                        linhaSplit = linha.Split(';');

                        Veiculo veiculo = new Veiculo(linhaSplit[0],linhaSplit[1], linhaSplit[2], int.Parse(linhaSplit[3]), double.Parse(linhaSplit[4]));

                        lista.Add(veiculo);

                    }

                } while (!leitor.EndOfStream);

                leitor.Close();

            }

            catch (IOException e)
            {
                Console.WriteLine("Erro ao ler arquivo: " + e.Message);
            }

            StreamWriter escritor = new StreamWriter(nomeArquivo, true);
            escritor.Close();
        }
        /// <summary>
        /// Método para persistir os dados no arquivo de veículos que estão utilizando o sistema.
        /// </summary>
        /// <param name="veiculo">Objeto da classe veículo com os dados de entrada</param>
        public static void gravarArquivoVeiculosEntrada(Veiculo veiculo)
        {
            string nomeArquivo = "veiculosEntrada.dat";

            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo, true);
                escritor.WriteLine(veiculo.PlacaVeiculo + ";" + veiculo.DataEntrada + ";" + veiculo.HoraEntrada);
                escritor.Flush();
                escritor.Close();
            }

            catch (IOException e)
            {
                Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
            }

        }
        /// <summary>
        /// Método para persistir os dados no arquivo de veículos que utilizaram o sistema.
        /// </summary>
        /// <param name="veiculo">Objeto da classe veículo com os dados de saída.</param>
        public static void gravarArquivoVeiculosSaida(Veiculo veiculo)
        {
            string nomeArquivo = "veiculosSaida.dat";

            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo, true);
                escritor.WriteLine(veiculo.PlacaVeiculo + ";" + veiculo.DataEntrada + ";" + veiculo.HoraEntrada + ";" + veiculo.TempoPermanencia + ";" + veiculo.ValorCobrado);
                escritor.Flush();
                escritor.Close();
            }

            catch (IOException e)
            {
                Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
            }

        }
        /// <summary>
        /// Método estático para limpar o arquivo de entrada quando o sistema se encontrar vazio.
        /// </summary>
        public static void limparArquivoVeiculosEntrada()
        {
            string nomeArquivo = "veiculosEntrada.dat";

            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo);
                escritor.WriteLine("");
                escritor.Flush();
                escritor.Close();
            }

            catch (IOException e)
            {
                Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
            }

        }
    }
}
