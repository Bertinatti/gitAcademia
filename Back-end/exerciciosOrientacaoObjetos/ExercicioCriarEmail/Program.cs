// See https://aka.ms/new-console-template for more information

// instancia o namespace de uso
using ExercicioCriarEmail;

// declaração das variáveis e das listas
List<Aluno> listaAlunos = new List<Aluno>();
List<Email> listaEmails = new List<Email>();
int opcao = 0;

// chama o método estático para conectar o arquivo
Util.conectaArquivo(listaAlunos, listaEmails);

// repetição do processo até que o usuário digite para sair
do
{
    Console.Write("===============================================================================================\n" +
                  "                                               MENU                                            \n" +
                  "===============================================================================================\n" +
                  "[1] - Cadastrar Aluno e gerar E-mail.\n" +
                  "[2] - Exibir lista de Aluno e E-mail.\n" +
                  "[3] - Exibir Alunos por Curso.\n" +
                  "[4] - Exibir e-mails.\n" +
                  "[5] - Adicionar semestre ao Aluno.\n" +
                  "[6] - Sair.\n" +
                  "Opção: ");
    opcao = int.Parse(Console.ReadLine());

    // menu para a escolha do usuário
    switch (opcao)
    {
        case 1:
            // cadastrar aluno e gerar e-mail
            try
            {
                // declaração das variáveis
                string nome, curso;
                int registroAluno, registroMatricula, opcaoCurso;
                DateTime dataMatricula = DateTime.Today;
                bool sair = false;
                bool jaCadastrado = false;

                // atribuição das variáveis
                registroAluno = 0;
                registroMatricula = 0;
                curso = "";

                // gera valores randomicos para o RA e o RGM
                Random randomRA = new Random(11);
                Random randomRGM = new Random(8);

                // verificação e validação do RA e RGM
                while (jaCadastrado == false)
                {
                    registroAluno = randomRA.Next();
                    registroMatricula = randomRGM.Next();
                    
                    foreach (Aluno a in listaAlunos)
                    {
                        if (a.RegistroAluno == registroAluno || a.RegistroMatrícula == registroMatricula)
                        {
                            jaCadastrado = true;
                        }
                    }
                    if (!jaCadastrado)
                    {
                        registroAluno = registroAluno;
                        registroMatricula = registroMatricula;
                        jaCadastrado = true;
                    }
                    else
                    {
                        jaCadastrado = false;
                    }
                    
                }

                // imprime a mensagem na tela, lê o que o usuário digitou e salva na variável
                Console.Write("Digite seu nome completo: ");
                nome = Console.ReadLine().ToLower();
                Console.WriteLine();

                // imprime a mensagem na tela, espera o retorno da opção e checa qual foi a opção escolhida pelo usuário
                Console.Write("Selecione o curso: \n" +
                              "[1] - Administração. \n" +
                              "[2] - Recursos Humanos.\n" +
                              "[3] - Análise e Desenvolvimentos de Sistemas. \n" +
                              "[4] - Engenharia Civil.\n" +
                              "Opção: ");
                opcaoCurso = int.Parse(Console.ReadLine());
                Console.WriteLine();

                // verificação de opção
                while (sair != true)
                {
                    switch (opcaoCurso)
                    {
                        case 1:
                            curso = "ADMINISTRAÇÃO";
                            sair = true;
                            break;
                        case 2:
                            curso = "RECURSOS HUMANOS";
                            sair = true;
                            break;
                        case 3:
                            curso = "ANÁLISE E DESENVOLVIMENTO DE SISTEMAS";
                            sair = true;
                            break;
                        case 4:
                            curso = "ENGENHARIA CIVIL";
                            sair = true;
                            break;
                        default:
                            Console.WriteLine("Opção inválida, digite outra opção");
                        break;
                    }

                }

                // criar os objetos das classes Aluno e Email
                Aluno aluno = new Aluno(nome, registroAluno, registroMatricula, dataMatricula, curso);
                Email email = new Email(nome, curso, registroMatricula);

                // adiciona o objeto a lista
                listaAlunos.Add(aluno);
                listaEmails.Add(email);

                // grava o objeto nos arquivos
                Util.gravarDados(aluno, email);

            }
            // captura o erro
            catch (IOException e)
            {
                Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
            }
            break;
        case 2:
            // exibe a lista
            Util.exibirListas(listaAlunos, listaEmails);
            break;
        case 3:
            // conta o número de alunos em cada curso
            int contADM, contRH, contADS, contENG;
            contADM = 0;
            contRH = 0;
            contADS = 0;
            contENG = 0;
            foreach (Aluno a in listaAlunos)
            {
                if (a.Curso.Equals("ADMINISTRAÇÃO"))
                {
                    contADM++;
                }
                else if (a.Curso.Equals("RECURSOS HUMANOS"))
                {
                    contRH++;
                }
                else if (a.Curso.Equals("ANÁLISE E DESENVOLVIMENTO DE SISTEMAS"))
                {
                    contADS++;
                }
                else
                {
                    contENG++;
                }  
            }
            Console.WriteLine("===============================================================================================\n" +
                              "Alunos por curso: \n" +
                              "===============================================================================================\n" +
                              "[1] - ADMINISTRAÇÃO:                          {0}\n" +
                              "[2] - RECURSOS HUMANOS:                       {1}\n" +
                              "[3] - ANÁLISE E DESENVOLVIMENTO DE SISTEMA:   {2}\n" +
                              "[4] - ENGENHARIA CIVIL:                       {3}\n" +
                              "===============================================================================================", contADM, contRH, contADS, contENG);
            break;
        case 4:
            // exibe os e-mails cadastrados
            Console.WriteLine("Lista de e-mails cadastrados:\n" +
                              "===============================================================================================");
            foreach (Email e in listaEmails)
            {
                Console.WriteLine("E-mail: {0}", e.EmailUsuario);
                Console.WriteLine("===============================================================================================");
            }
            break;
        case 5:
            // adicionar semestre no curso do aluno
            Console.Write("Digite o nome do aluno que deseja atribuir um semestre: ");
            string nomeAluno = Console.ReadLine();
            foreach (Aluno a in listaAlunos)
            {
                if (a.Nome.Equals(nomeAluno.ToLower()))
                {
                    a.adicionaSemestre();
                }
            }
            break;
        case 6:
            // sair do programa
            Console.WriteLine("Obrigado por usar o programa.");
            break;
        default:
            // valores diferentes do definidos
            break;
    }

    // imprime a mensagem e espera o retorno de uma tecla
    Console.WriteLine("Pressione uma tecla para sair.");
    Console.ReadKey();

    // limpa o console
    Console.Clear();

    // imprime a mensagem de saída
    Console.WriteLine("SAINDO...");

} while (opcao != 6);

