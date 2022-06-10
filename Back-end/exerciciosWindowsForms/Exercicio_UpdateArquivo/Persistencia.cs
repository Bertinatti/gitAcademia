using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_UpdateArquivo
{
    internal class Persistencia
    {
        /// <summary>
        /// Método para persistir os dados no arquivo.
        /// </summary>
        /// <param name="lista"></param>
        public static void gravarNoArquivo(List<Pessoa> lista)
        {
            StreamWriter escritor = new StreamWriter("pessoas.dat");
            foreach (Pessoa pessoa in lista)
            {
                escritor.WriteLine(pessoa.NomeCompleto + ";" + pessoa.Email);
                escritor.Flush();
            }
            escritor.Close();
        }

        /// <summary>
        /// Método para ler os dados persistidos no arquivo.
        /// </summary>
        /// <param name="lista"></param>
        public static void trazerDoArquivo(List<Pessoa> lista)
        {
            StreamReader leitor = new StreamReader("pessoas.dat");
            string[] vetorDados;
            string linha;
            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(';');

                lista.Add(new Pessoa(vetorDados[0], vetorDados[1]));
            } while (!leitor.EndOfStream);
            leitor.Close();
        }
    }
}
