// See https://aka.ms/new-console-template for more information

/*
 * #1
 * Implemente um programa em C# no qual o usuário deverá informar o nome e o poder (0 a 10) de três personagens. 
 * O programa deverá informar o nome do personagem que possuir o maior poder.
 * 
 * Regras que deverão ser seguidas para a implementação do algoritmo:
 * 
 * É obrigatório o uso de classe para representar um Personagem e a mesma deverá possuir como propriedades (características) um nome e um poder.
 * A classe também deverá possuir um método chamado ExibirDados. Esse método deverá exibir o nome e o poder do personagem em questão.
 * Ao implementar a classe é obrigatório implementar dois construtores (Sobrecarga), um que não recebe parâmetro algum e outro que 
 * irá receber o nome e o poder de um personagem
 **/

// instanciando o namespace Exercicio001
using Exercicio001;

// declaração da lista do tipo personagem
List<Personagem> listaPersonagem = new List<Personagem>();

// repetição para adicionar os 3 personagens a lista
for (int i = 0; i < 3; i++)
{
    // limpa a tela, imprime a mensagem na tela, lê o valor digitado pelo usuário e salva na lista
    Console.Clear();
    Personagem p = new Personagem();
    Console.Write("Digite o nome do {0}º personagem: ", i + 1);
    p.Nome = Console.ReadLine().ToUpper();
    Console.WriteLine();

    // repetição infinita para validar a entrada do atributo PODER
    while (true)
    {
        Console.Write("Digite o poder do {0}º personagem: ", i + 1);
        int poder = int.Parse(Console.ReadLine());
        Console.WriteLine();
        
        if (poder >= 0 && poder <= 10)
        {
            p.Poder = poder;
            break;
        }
        else
        {
            Console.WriteLine("Digite um poder válido, de 0 a 10.");
            Console.WriteLine();
        }
    }

    // chamada do metodo ExibirDados() - apenas para exemplificação
    p.ExibirDados();

    // adição do personagem a lista
    listaPersonagem.Add(p);

    // imprime a mensagem na tela e espera o input de uma tecla 
    Console.WriteLine("Pressione alguma tecla para continuar.");
    Console.ReadKey();
}

// declaração de variáveis "temporarias"
int tmpPoder = 0;
string tmpNome = "";
int contNomes = 0;

// repetição para percorrer toda a lista
foreach (Personagem i in listaPersonagem)
{
    // verifica se o poder do personagem é o maior poder
    if (i.Poder > tmpPoder)
    {
        tmpPoder = i.Poder;
        tmpNome = i.Nome;
    }
    // verifica se o poder é igual ao maior poder salvo
    else if (i.Poder == tmpPoder)
    {
        tmpPoder = i.Poder;
        tmpNome += Convert.ToString(", " + i.Nome);
        contNomes++;
    }
}

// verifica se existe mais de um personagem com o valor maximo de poder  
if(contNomes > 0)
{
    Console.WriteLine("O maior poder é {0}, que pertence aos personagens {1}.\n", tmpPoder, tmpNome.ToUpper());
}
// caso não existe, continua com o curso normal do programa
else
{
    Console.WriteLine("O maior poder é {0}, que pertence ao personagem {1}.\n", tmpPoder, tmpNome.ToUpper());
}

// imprime a mensagem de saída na tela
Console.WriteLine("Saindo da aplicação...");