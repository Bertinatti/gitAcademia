// See https://aka.ms/new-console-template for more information

//using Exercicio005;

//string opcao = "";

//string nomeArquivo = "emails.txt"; //texto puro -> plain text

//List<Pessoa> listaPessoa = new List<Pessoa>();
//List<string> listaNome = new List<string>();
//List<string> listaEmail = new List<string>();

//try
//{
//    StreamReader leitor = new StreamReader(nomeArquivo);
//    do
//    {
//        listaNomeEmail.Add(leitor.ReadLine());

//        string linha = leitor.ReadLine();

//        string[] nomeEmail = linha.Split(";");

//        listaNomeEmail.Add(linha);

//        listaNome.Add(nomeEmail[0]);

//        listaEmail.Add(nomeEmail[1]);

//    } while (!leitor.EndOfStream);

//    leitor.Close();

//}
//catch (IOException e)
//{
//    //Console.WriteLine("Erro ao ler arquivo: " + e.Message);
//}


using Exercicio005;

string opcao = "";

string nomeArquivo = "emails.txt"; //texto puro -> plain text

List<Pessoa> listaPessoa = new List<Pessoa>();

try
{
    StreamReader leitor = new StreamReader(nomeArquivo);
    do
    {

        string linha = leitor.ReadLine();

        string[] nomeEmail = linha.Split(";");

        Pessoa p = new Pessoa(nomeEmail[0], nomeEmail[1]);

        listaPessoa.Add(p);

    } while (!leitor.EndOfStream);

    leitor.Close();

}
catch (IOException e)
{
    //Console.WriteLine("Erro ao ler arquivo: " + e.Message);
}

StreamWriter escritor = new StreamWriter(nomeArquivo, true); //abre o arquivo para escrita

do
{
    Console.Clear();
    Console.Write("=================================================\n" +
                  "                       MENU                      \n" +
                  "=================================================\n" +
                  "[1] - Cadastrar nome e e-mail.\n" +
                  "[2] - Exibir dados.\n" +
                  "[3] - Exibir nomes.\n" +
                  "[4] - Exibir e-mails.\n" +
                  "[5] - Sair.\n" +
                  "Opção: ");
    opcao = Console.ReadLine();
    Console.WriteLine("=================================================");
    Console.WriteLine();

    switch (opcao)
    {
        case "1":
            //receber um email e gravar no arquivo
            try
            {

                string nome, email, arquivo;
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine().ToLower();
                Console.WriteLine();

                Console.Write("Digite email: ");
                email = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (!listaEmail.Contains(email))
                {
                    arquivo = $"{nome};{email}";

                    listaNomeEmail.Add(arquivo);
                    listaNome.Add(nome);
                    listaEmail.Add(email);

                    escritor.WriteLine(arquivo); //literalmente escreve no procurador e em memória

                    escritor.Flush(); //garante depois de cada frase digitada que vá para o arquivo

                    escritor.Close(); //fecha o objeto que representa o arquivo
                }

                else
                {
                    Console.WriteLine("E-mail já cadastrado.\n");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
            }

            break;
        case "2":
            foreach (string i in listaNomeEmail)
            {
                Console.WriteLine(i);
            }
            break;
        case "3":
            Console.WriteLine("Exibindo nomes cadastrados.\n");
            if (listaNomeEmail.Count == 0)
            {
                Console.WriteLine("Lista Vazia!\n");
            }
            else
            {
                foreach (string i in listaNome)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine();
            }
            break;
        case "4":
            Console.WriteLine("Exibindo nomes cadastrados.\n");
            if (listaNomeEmail.Count == 0)
            {
                Console.WriteLine("Lista Vazia!\n");
            }
            else
            {
                foreach (string i in listaEmail)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine();
            }
            break;
        case "5":
            Console.WriteLine("Obrigado por usar o sistema.\n");
            break;
        default:
            Console.WriteLine("Opção inválida!\n");
            break;
    }
    Console.Write("Pressione algo para continuar!");
    Console.ReadKey();
    Console.WriteLine();
} while (opcao != "5");
