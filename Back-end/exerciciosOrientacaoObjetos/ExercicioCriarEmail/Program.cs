// See https://aka.ms/new-console-template for more information

using ExercicioCriarEmail;

List<Aluno> listaAlunos = new List<Aluno>();
List<Email> listaEmails = new List<Email>();
int opcao = 0;

Util.conectaArquivo(listaAlunos, listaEmails);

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

    switch (opcao)
    {
        case 1:
            try
            {
                string nome, curso;
                int registroAluno, registroMatricula, opcaoCurso;
                DateTime dataMatricula = DateTime.Today;
                bool sair = false;
                bool jaCadastrado = false;

                registroAluno = 0;
                registroMatricula = 0;
                curso = "";

                Random randomRA = new Random(11);
                Random randomRGM = new Random(8);

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

                Console.Write("Digite seu nome completo: ");
                nome = Console.ReadLine().ToLower();
                Console.WriteLine();

                Console.Write("Selecione o curso: \n" +
                              "[1] - Administração. \n" +
                              "[2] - Recursos Humanos.\n" +
                              "[3] - Análise e Desenvolvimentos de Sistemas. \n" +
                              "[4] - Engenharia Civil.\n" +
                              "Opção: ");
                opcaoCurso = int.Parse(Console.ReadLine());
                Console.WriteLine();

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

                Aluno aluno = new Aluno(nome, registroAluno, registroMatricula, dataMatricula, curso);
                Email email = new Email(nome, curso, registroMatricula);

                listaAlunos.Add(aluno);
                listaEmails.Add(email);

                Util.gravarDados(aluno, email);

            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
            }
            break;
        case 2:
            Util.exibirListas(listaAlunos, listaEmails);
            break;
        case 3:
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
            break;
        case 5:
            break;
        case 6:
            Console.WriteLine("Obrigado por usar o programa.");
            break;
        default:
            break;
    }

    Console.WriteLine("Pressione uma tecla para sair.");
    Console.ReadKey();

    Console.Clear();

    Console.WriteLine("SAINDO...");

} while (opcao != 6);

