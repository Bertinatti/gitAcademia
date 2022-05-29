using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCriarEmail
{
    internal class Util
    {
        // método estático para conectar ao arquivo
        public static void conectaArquivo(List<Aluno> listaAluno, List<Email> listaEmail)
        {
            // declaração das variáveis com os nomes dos arquivos
            string nomeArquivoAluno = "ListaAlunos.txt";
            string nomeArquivoEmail = "ListaEmails.txt";

            // tenta realizar a conexão e a leitura do arquivo
            try
            {
                StreamReader leitor1 = new StreamReader(nomeArquivoAluno);
                string linha1;
                string[] linhaSplit1;

                do 
                { 

                    linha1 = leitor1.ReadLine();

                    if (linha1 != null)
                    {
                        linhaSplit1 = linha1.Split(";");

                        Aluno a = new Aluno(linhaSplit1[0], linhaSplit1[1], Convert.ToInt32(linhaSplit1[2]), Convert.ToInt32(linhaSplit1[3]), Convert.ToDateTime(linhaSplit1[4]), linhaSplit1[5], Convert.ToDateTime(linhaSplit1[6]));

                        listaAluno.Add(a);

                    }

                } while (!leitor1.EndOfStream);

                // fecha os leitores
                leitor1.Close();

            }
            // captura o erro - nesse caso não será mostrado e só continuará
            catch (IOException e)
            {
                Console.WriteLine("Erro ao ler arquivo: " + e.Message);
            }

            // tenta conectar no arquivo e realizar a leitura
            try
            {
                StreamReader leitor2 = new StreamReader(nomeArquivoEmail);
                string linha2;
                string[] linhaSplit2;

                do
                {

                    linha2 = leitor2.ReadLine();
                    if(linha2 != null)
                    {
                        linhaSplit2 = linha2.Split(";");

                        Email e = new Email(linhaSplit2[0], linhaSplit2[1], linhaSplit2[2], Convert.ToInt32(linhaSplit2[3]));

                        listaEmail.Add(e);
                    }
                    
                } while (!leitor2.EndOfStream);

                // fecha os leitores
                leitor2.Close();

            }
            // captura o erro - nesse caso não será mostrado e só continuará
            catch (IOException e)
            {
                Console.WriteLine("Erro ao ler arquivo: " + e.Message);
            }

            // instancia o objeto da classe StreamWriter
            StreamWriter escritor1 = new StreamWriter(nomeArquivoAluno, true); 
            StreamWriter escritor2 = new StreamWriter(nomeArquivoEmail, true);

            // fecha os escritores
            escritor1.Close();
            escritor2.Close();

        }

        // métodos estático para exibir as listas
        public static void exibirListas(List<Aluno> listaAluno, List<Email> listaEmail)
        {
            if(listaAluno.Count == 0  && listaEmail.Count == 0)
            {
                Console.WriteLine("As listas estão vazias.");
            }
            else
            {
                Console.WriteLine("Mostrando as listas Aluno e E-mail: ");
                Console.WriteLine("===================================================================================================================");
                foreach (Aluno a in listaAluno)
                {
                    Console.WriteLine("Nome: {0} - RA: {1} - RGM: {2} - Curso: {3} - Data da Matrícula: {4:dd/MM/yyyy} - Data do Término: {5:dd/MM/yyyy}.", a.Nome.ToUpper(), a.RegistroAluno, a.RegistroMatrícula, a.Curso, a.DataMatricula, a.DataTermino);
                    foreach (Email e in listaEmail)
                    {
                        if (e.RegistroMatricula.Equals(a.RegistroMatrícula))
                        {
                            Console.WriteLine("Email: {0}", e.EmailUsuario);
                            Console.WriteLine("===================================================================================================================");
                        }
                    }
                }
            }
        }

        // método estático para gravar os dados
        public static void gravarDados(Aluno aluno, Email email)
        {
            // declaração das variáveis com os nomes dos arquivos
            string nomeArquivoAluno = "ListaAlunos.txt";
            string nomeArquivoEmail = "ListaEmails.txt";

            // tenta conectar com o arquivo e realizar a leitura
            try
            {
                StreamWriter escritor1 = new StreamWriter(nomeArquivoAluno, true);
                escritor1.WriteLine(aluno.Nome + ";" + aluno.Sobrenome + ";" + aluno.RegistroAluno + ";" + aluno.RegistroMatrícula + ";" + aluno.DataMatricula + ";" + aluno.Curso + ";" + aluno.DataTermino);
                escritor1.Flush();
                escritor1.Close();
            }
            // captura o erro
            catch (IOException e)
            {
                Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
            }

            // tenta conectar com o arquivo e realizar a leitura
            try
            {
                StreamWriter escritor2 = new StreamWriter(nomeArquivoEmail, true);
                escritor2.WriteLine(email.EmailUsuario + ";" + email.Nome + ";" + email.Curso + ";" + email.RegistroMatricula);
                escritor2.Flush();
                escritor2.Close();
            }
            // captura o erro
            catch (IOException e)
            {
                Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
            }
        }
    }
}
