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
                 "[2] - Exibir dados.\n" +
                 "[3] - Exibir nomes.\n" +
                 "[4] - Exibir e-mails.\n" +
                 "[5] - Exibir os domínios.\n" +
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
                    if(listaAlunos.Count == 0)
                    {
                        registroAluno = registroAluno;
                        registroMatricula = registroMatricula;
                        jaCadastrado = true;
                    }
                    else
                    {
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
                        }
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
                              "Opção: \n");
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
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
        default:
            break;
    }

    Console.WriteLine("Pressione uma tecla para sair.");
    Console.ReadKey();

    Console.Clear();

} while (opcao != 6);

