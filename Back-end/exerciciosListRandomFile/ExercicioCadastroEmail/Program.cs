// See https://aka.ms/new-console-template for more information

// chamando o objeto
using ExercicioCadastroEmail;

// declaração da variável para receber a opção do usuário no menu
string opcao = "";

// variável declarada e atribuída com o nome do arquivo que será lido
string nomeArquivo = "emails.txt"; //texto puro -> plain text

// declaração das listas e da lista da classe Pessoa
List<Pessoa> listaPessoa = new List<Pessoa>();
List<string> listaNome = new List<string>();
List<string> listaEmail = new List<string>();
List<string> listaDominio = new List<string>();

// tenta fazer a ação
try
{
    StreamReader leitor = new StreamReader(nomeArquivo);
    do
    {

        string linha = leitor.ReadLine();

        string[] nomeEmail = linha.Split(";");

        Pessoa p = new Pessoa(nomeEmail[0], nomeEmail[1]);

        listaPessoa.Add(p);
        listaNome.Add(nomeEmail[0]);
        listaEmail.Add(nomeEmail[1]);

        string emailSplit = p.email;
        string[] passaDominio = emailSplit.Split("@");
        string dominio = passaDominio[1];

        if (!listaDominio.Contains(dominio))
        {
            listaDominio.Add(dominio);
        }

    } while (!leitor.EndOfStream);

    leitor.Close();

}
// captura o erro - nesse caso não será mostrado e só continuará
catch (IOException e)
{
    //Console.WriteLine("Erro ao ler arquivo: " + e.Message);
}

// instancia o objeto da classe StreamWriter
StreamWriter escritor = new StreamWriter(nomeArquivo, true); //abre o arquivo para escrita

// looping para realizar as operações, que se encerra quando o usuário digitar o número 6
do
{
    // imprime na tela o menu, lê a opção e salva na variável para ser usada no Switch
    Console.Clear();
    Console.Write("===============================================================================================\n" +
                  "                                               MENU                                            \n" +
                  "===============================================================================================\n" +
                  "[1] - Cadastrar nome e e-mail.\n" +
                  "[2] - Exibir dados.\n" +
                  "[3] - Exibir nomes.\n" +
                  "[4] - Exibir e-mails.\n" +
                  "[5] - Exibir os domínios.\n" +
                  "[6] - Sair.\n" +
                  "Opção: ");
    opcao = Console.ReadLine();
    Console.WriteLine("===============================================================================================");
    Console.WriteLine();

    // efetua a verificação da opção digitada pelo usuário
    switch (opcao)
    {
        case "1":
            // tenta cadastrar um email na variável e salva abaixo da última posição do arquivo
            try
            {

                string nome, email, arquivo;
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine().ToLower();
                Console.WriteLine();

                Console.Write("Digite email: ");
                email = Console.ReadLine().ToLower();
                Console.WriteLine();

                Pessoa p = new Pessoa(nome, email);

                // variável auxiliar para a verificação do email
                bool jaCadastrado = false;

                // verifica se o email já foi cadastrado
                foreach (Pessoa i in listaPessoa)
                {
                    if (i.email.Equals(email))
                    {
                        Console.WriteLine("E-mail já cadastrado.");
                        jaCadastrado = true;
                        break;
                    }
                }

                // efetua a checagem da variável auxiliar para ver se o email pode ser cadastrado
                if (!jaCadastrado)
                {
                    arquivo = $"{p.nome};{p.email}";

                    // adiciona os respectivos valores as listas
                    listaPessoa.Add(p);
                    listaNome.Add(p.nome);
                    listaEmail.Add(p.email);

                    // adiciona a lista do domínio se o domínio for novo
                    string emailSplit = p.email;
                    string[] passaDominio = emailSplit.Split("@");
                    string dominio = passaDominio[1];
                    
                    if (!listaDominio.Contains(dominio))
                    {
                        listaDominio.Add(dominio);
                    }

                    // escreve no objeto e na memória
                    escritor.WriteLine(arquivo); 

                    // descarrega os dados salvo no objeto direto no arquivo
                    escritor.Flush(); 

                }
            }
            // captura os erros
            catch (IOException e)
            {
                Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
            }
            break;
        case "2":
            // repetição para exibir os nomes e os emails cadastros na listaPessoa
            if (listaPessoa.Count == 0)
            {
                Console.WriteLine("A lista  está vazia!\n");
            }
            else
            {
                Console.WriteLine("Exibindo os nomes e e-mails cadastrados.\n");
                foreach (Pessoa i in listaPessoa)
                {
                    Console.WriteLine("Nome: " + i.nome.ToUpper() + " E-mail: " + i.email);
                }
            }
            Console.WriteLine();
            break;
        case "3":
            // repetição para exibir os nomes cadastrados na listaNome
            if (listaNome.Count == 0)
            {
                Console.WriteLine("Lista Vazia!\n");
            }
            else
            {
                Console.WriteLine("Exibindo nomes cadastrados.\n");
                foreach (string i in listaNome)
                {
                    Console.WriteLine(i.ToUpper());
                }

                Console.WriteLine();
            }
            break;
        case "4":
            // repetição para exibir os emails cadastrados na listaEmail
            if (listaEmail.Count == 0)
            {
                Console.WriteLine("Lista de e-mail está vazia!\n");
            }
            else
            {
                Console.WriteLine("Exibindo e-mails cadastrados.\n");
                foreach (string i in listaEmail)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine();
            }
            break;
        case "5":
            if (listaDominio.Count == 0)
            {
                Console.WriteLine("Lista de domínios está vazia!\n");
            }
            else
            {
                foreach (string i in listaDominio)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            }
            break;
        case "6":
            Console.WriteLine("Obrigado por usar o sistema.\n");
            break;
        default:
            Console.WriteLine("Opção inválida!\n");
            break;
    }
    Console.Write("Pressione algo para continuar!");
    Console.ReadKey();
    Console.WriteLine();
} while (opcao != "6");