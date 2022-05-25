// See https://aka.ms/new-console-template for more information

/* 
 * 2) Fazer um programa em VS que permita o usuário cadastrar emails de clientes (em uma lista). 
 * Uma vez cadastrados os emails, o programa deve separar o nome de usuário (antes do @) do domínio do email 
 * (depois do @). Ao final, o programa deve exibir os domínios utilizados no cadastro (não pode exibir os repetidos).
 * Observação: os domínio são, por exemplo, gmail.com; yahoo.com.br; ufn.edu.br; hotmail.com; entre outros.
 * 
 * Sugere-se usar um menu como:
 * 
 * MENU 
 * 1 - Cadastrar emails
 * 2 - Mostrar lista de emails
 * 3 - Mostrar dominíos de emails
 * 4 - Sair
 * Opção:____
 **/

// declaração das variáveis e das listas
List<string> listaEmails = new List<string>();
List<string> listaDominios = new List<string>();
string opcao;

// repetição do programa até receber o valor de saída
do
{
    // limpa a tela, imprime o menu na tela, lê o que foi digitado pelo usuário e salva na variável
    Console.Clear();
    Console.Write("===================================MENU===================================\n" +
                  "[1] - Cadastrar e-mail.\n" +
                  "[2] - Exibir lista de e-mails.\n" +
                  "[3] - Mostrar os domínios dos e-mails.\n" +
                  "[4] - Sair.\n" +
                  "==========================================================================\n" +
                  "Opção: ");
    opcao = Console.ReadLine();
    Console.WriteLine();

    // seleciona a variável e verifica qual opção foi escolhida e executa
    switch (opcao)
    {
        // cadastra o e-mail
        case "1":
            Console.WriteLine("Cadastrando um e-mail.\n");
            string email;
            Console.Write("Digite o e-mail: ");
            email = Console.ReadLine().ToUpper();
            Console.WriteLine();

            if (listaEmails.Contains(email))
            {
                Console.WriteLine("O e-mail já está cadastrado.\n");
            }
            else
            {
                listaEmails.Add(email);

                string[] emailSplit;
                string dominio;
                emailSplit = email.Split("@");
                dominio = emailSplit[1];
                if (!listaDominios.Contains(dominio))
                {
                    listaDominios.Add(dominio);
                }
                listaDominios.Sort();
                Console.WriteLine("O e-mail foi cadastrado com sucesso.\n");
            }
            break;

        // exibe a lista dos e-mails
        case "2":
            Console.WriteLine("Exibindo a lista de e-mails cadastrados.\n");
            if (listaEmails.Count == 0)
            {
                Console.WriteLine("A lista está vazia!\n");
            }
            else
            {
                for (int i = 0; i < listaEmails.Count; i++)
                {
                    Console.WriteLine(listaEmails[i]);
                }
                Console.WriteLine();
                // foreach (int i in listaEmails)
                // {
                //     Console.WriteLine(i);
                // }
            }
            break;

        // exibe os domínios
        case "3":
            Console.WriteLine("Exibindo os domínios dos e-mails cadastrados.\n");
            if (listaEmails.Count == 0)
            {
                Console.WriteLine("A lista vazia!\n");
            }
            else
            {
                //listaDominios.Sort(); - poderia ser aqui
                foreach (string i in listaDominios)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            }
            break;
        // opção de saída
        case "4":
            Console.WriteLine("Obrigado por usar o sistema.\n");
            break;

        // opção padrão para retornar quando um valor digitado nao corresponde aos esperados acima
        default:
            Console.WriteLine("Opção inválida!\n");
            break;
    }

    // imprime a mensagem na tela e aguarda o clique de uma tela
    Console.Write("Pressione algo para continuar!\n");
    Console.ReadKey();
} while (opcao != "4");
