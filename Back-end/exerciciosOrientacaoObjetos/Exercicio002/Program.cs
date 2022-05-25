// See https://aka.ms/new-console-template for more information

/*
 * #2
 * Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
 * O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.
 * 
 * Regras que deverão ser seguidas para a implementação do programa:
 * 
 * Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
 * Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
 * É obrigatório criar uma classe para representar o Animal.
 * A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
 * A classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).
 * 
 **/

// 
using Exercicio002;

// declaração das variáveis e lista
List<Animal> listaAnimal = new List<Animal>();
int contCachorro, contGato, contPeixe;

// atribuição de valor as variáveis de contagem
contCachorro = 0;
contGato = 0;
contPeixe = 0;

// repetição para cadastrar os 5 animais
for (int i = 0; i < 5; i++)
{
    // limpa a tela, imprime a mensagem na tela, lê o que foi digitado pelo usuário e salva na variável
    Console.Clear();
    Console.Write("Digite o nome do {0}º animal de estimação: ", i + 1);
    string nome = Console.ReadLine().ToUpper();
    Console.WriteLine();

    string tipo;

    // repetição infinita que valida os dados do tipo do animal
    while (true)
    {
        Console.Write("Digite o tipo do {0}º animal(cachorro, gato ou peixe): ", i + 1);
        tipo = Console.ReadLine().ToUpper();
        Console.WriteLine();

        // verifica se o tipo digitado foi correto, salva os valores no objeto e na lista para poder quebrar a repetição infinita
        if (tipo.Equals("CACHORRO") || tipo.Equals("GATO") || tipo.Equals("PEIXE"))
        {
            Animal a = new Animal(nome, tipo);
            listaAnimal.Add(a);
            break;
        }
        // caso não valida o tipo, imprime a mensagem na tela e pede para que digite um valor válido
        else
        {
            Console.WriteLine("O tipo do animal digitado não corresponde aos tipos válidos, digite um tipo válido.\n");
        }
    }

    // imprime a mensagem na tela e espera o pressionamento de uma tecla
    Console.WriteLine("Pressione uma tecla para continuar.");
    Console.ReadKey();
}

// repetição que verifica os valores da lista e faz a contagem de animas separados por tipo
foreach (Animal a in listaAnimal)
{
    // verifica se é cachorro
    if (a.Tipo.Equals("CACHORRO"))
    {
        contCachorro++;
    }
    // verifica se é gato
    else if (a.Tipo.Equals("GATO"))
    {
        contGato++;
    }
    // por fim, define que sobrou somente animais do tipo peixe
    else
    {
        contPeixe++;
    }
}

// imprime na tela a mensagem de contagem de animais, informado a quantidade de cada tipo de animal
Console.WriteLine("=======================================================\n" +
                  "                  CONTAGEM DE ANIMAIS                  \n" +
                  "=======================================================\n" +
                  "[1] - Cachorros:                                     {0}\n" +
                  "[2] - Gatos:                                         {1}\n" +
                  "[3] - Peixes:                                        {2}\n" +
                  "=======================================================\n", contCachorro, contGato, contPeixe);