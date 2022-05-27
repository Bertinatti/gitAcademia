using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPrimeiraParte
{
    internal class Util
    {
        // método estático para conectar com o arquivo de base
        public static void conectaArquivo(List<Veiculo> listaVeiculos)
        {
            // atribui o nome do arquivo a variável 
            string nomeArquivo = "ListaVeiculos.dat";

            // tenta realizar a operação de leitura
            try
            {
                // instanciação do objeto leitor
                StreamReader leitor = new StreamReader(nomeArquivo);

                // declaração das variáveis
                string linha;
                string[] linhaSplit;

                // repetição para ler os valores que estão salvos na base
                do
                {
                    // efetua a letirua da linha do arquivo
                    linha = leitor.ReadLine();

                    // verifica se o arquivo não está nulo
                    if (linha != null)
                    {
                        // separa os atributos do arquivo de base
                        linhaSplit = linha.Split(";");

                        // instancia o objeto veiculo e envia os atributos via método construtor
                        Veiculo veiculo = new Veiculo(linhaSplit[0], Convert.ToDateTime(linhaSplit[1]));

                        // adiciona o objeto a lista de veiculos
                        listaVeiculos.Add(veiculo);

                    }

                } while (!leitor.EndOfStream);

                // fecha o leitor
                leitor.Close();

            }
            // captura o erro
            catch (IOException e)
            {
                // imprime a mensagem de erro
                Console.WriteLine("Erro ao ler arquivo: " + e.Message);
            }

            // caso a lista esteja vazia, ele iria criar um novo arquivo e em seguida ja irá fecha-lo
            StreamWriter escritor = new StreamWriter(nomeArquivo, true);
            escritor.Close();
        }

        // método estático para exibir o conteúdo da lista
        public static void exibirListas(List<Veiculo> listaVeiculo)
        {
            // verifica se a lista está vazia
            if (listaVeiculo.Count == 0)
            {
                // imprime a mensagem na tela
                Console.WriteLine("A lista está vazia.");
            }
            else
            {
                // imprime as mensagens na tela
                Console.WriteLine("Mostrando os veículos cadastrados: ");
                Console.WriteLine("===================================================================================");

                // repete a leitura de cada objeto da lista e imprime os valores na tela
                foreach (Veiculo v in listaVeiculo)
                {
                    Console.WriteLine("Placa: {0} - Data da Entrada: {1:dd/MM/yyyy hh:mm}", v.Placa, v.DataHoraEntrada);
                    Console.WriteLine("===================================================================================");
                }
            }
        }

        // método estáticoa para gravar os dados no arquivo de base
        public static void gravarDados(Veiculo veiculo)
        {
            // atribui o nome do arquivo a variável
            string nomeArquivo = "ListaVeiculos.dat";

            // tenta realizar a operação de gravação de dados
            try
            {
                // instancia o objeto escritor para gravar os dados
                StreamWriter escritor = new StreamWriter(nomeArquivo, true);
                // escreve o valor na linha do arquivo abaixo da última posição
                escritor.WriteLine(veiculo.Placa + ";" + veiculo.DataHoraEntrada);
                // enviar ou descarrega os dados pro arquivo
                escritor.Flush();
                // fecha o objeto escritor
                escritor.Close();
            }
            // captura a mensagem de erro
            catch (IOException e)
            {
                // imprime a mensagem de erro na tela
                Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
            }

        }

        // método estático que retorno o valor da opção
        public static int mostrarMenu()
        {
            // limpa o menu
            Console.Clear();

            // imprime o menu na tela, lê o valor digitado pelo usuário e salva na variável
            Console.Write("===============================================================================================\n" +
                          "                                               MENU                                            \n" +
                          "===============================================================================================\n" +
                          "[1] - Cadastrar veículo entrando na garagem.\n" +
                          "[2] - Exibir veículos cadastrados.\n" +
                          "[3] - Sair.\n" +
                          "Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            // retorna o valor digitado pelo usuário
            return opcao;
        }

        // método estático para executar o que foi escolhido pelo usuário no menu
        public static void resultadoMenu(int opcao, List<Veiculo> listaVeiculos)
        {
            // escolha
            switch (opcao)
            {
                // cadastra o veículo
                case 1:
                    try
                    {
                        // declaração das variáveis
                        string placa = "";
                        bool jaCadastrado = false;

                        // repetição infinita que verifica se a placa foi repetida
                        while (true)
                        {
                            // imprime a mensagem na tela, lê o que o usuário digitou e salva na variável
                            Console.Write("Digite a placa do veículos: ");
                            placa = Console.ReadLine().ToUpper();

                            // verifica se na lista existe alguma placa igual a que foi digitada
                            foreach (Veiculo v in listaVeiculos)
                            {
                                // comparação
                                if (v.Placa.Equals(placa))
                                {
                                    jaCadastrado = true;
                                }
                            }
                            // verifica para ver se a placa não está cadastras - consideração errada: seria melhor verificar se a placa, a data/hora e a saída ou entrada estão ok
                            if (!jaCadastrado)
                            {
                                // caso não esteja cadastrado, salva o valor na variável e fecha a repetição
                                placa = placa.ToUpper();
                                break;
                            }
                            // se estiver cadastrado, pede pra que digite uma placa diferente
                            else
                            {
                                // imprime a mensagem na tela e altera o valor para continuar a repetição
                                Console.WriteLine("A placa já está cadastrada.");
                                jaCadastrado = false;
                            }                            
                        }

                        // instancia o objeto e salva a placa pelo metodo construtor
                        Veiculo veiculo = new Veiculo(placa);

                        // adiciona o objeto a lista
                        listaVeiculos.Add(veiculo);

                        // chama o metodo para gravar os dados
                        Util.gravarDados(veiculo);

                    }
                    // captura os erros
                    catch (IOException e)
                    {
                        // imprime a mensagem de erro na tela
                        Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
                    }
                    break;
                // exibe a lista na tela
                case 2:
                    // chama o metodo para exibir os dados da lista
                    Util.exibirListas(listaVeiculos);
                    break;
                // saí do programa
                case 3:
                    // imprime a mensagem de saída na tela
                    Console.WriteLine("Obrigado por usar o sistema.");
                    break;
                // valores inválidos
                default:
                    // imprime a mensagem na tela
                    Console.WriteLine("Opção inválida. Digite uma opção válida.");
                    break;
            }
        }
    }
}
