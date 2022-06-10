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

                    if (linha != null)
                    {
                        linhaSplit = linha.Split(';');

                        Veiculo veiculo = new Veiculo(linhaSplit[0], Convert.ToDateTime(linhaSplit[1]), Convert.ToDateTime(linhaSplit[2]));

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

                    if (linha != null)
                    {
                        linhaSplit = linha.Split(';');

                        Veiculo veiculo = new Veiculo(linhaSplit[0], int.Parse(linhaSplit[1]), double.Parse(linhaSplit[2]));

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
        public static void gravarArquivoVeiculosSaida(Veiculo veiculo)
        {
            string nomeArquivo = "veiculosEntrada.dat";

            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo, true);
                escritor.WriteLine(veiculo.PlacaVeiculo + ";" + veiculo.TempoPermanencia + ";" + veiculo.ValorCobrado);
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
