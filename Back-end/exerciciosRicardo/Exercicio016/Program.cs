// See https://aka.ms/new-console-template for more information

/* 
 * Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
 * na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
 * enfrentar novamente em um novo jogo.
 * ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
 * ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
 * plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.
 **/

// declaração das variáveis
int golCasaPartida1, golForaPartida1, golCasaPartida2, golForaPartida2, totalTime1, totalTime2;

// imprime a mensagem na tela, lê o valor digitado pelo usuário e salva na respectiva variável
Console.Write("Digite os gols do time da casa no jogo 1: ");
golCasaPartida1 = int.Parse(Console.ReadLine());
Console.Write("Digite os gols do time de fora no jogo 1: ");
golForaPartida1 = int.Parse(Console.ReadLine());

// efetua a condicional do programa
if (golForaPartida1 >= golCasaPartida1 + 2)
{
    Console.WriteLine("O time de fora se classificou para a próxima fase");
}
else
{
    Console.WriteLine("Os times irão se enfrentar em um novo jogo.");
    Console.Write("Digite os gols do time da casa no jogo 2: ");
    golCasaPartida2 = int.Parse(Console.ReadLine());
    Console.Write("Digite os gols do time de fora no jogo 2: ");
    golForaPartida2 = int.Parse(Console.ReadLine());

    totalTime1 = golCasaPartida1 + golForaPartida2;
    totalTime2 = golForaPartida1 + golCasaPartida2;

    if (totalTime1 > totalTime2)
    {
        Console.WriteLine("O time A se classificou no segundo jogo fora de casa.");
    }
    else if (totalTime2 > totalTime1)
    {
        Console.WriteLine("O time B se classificou no segundo jogo dentro de casa.");
    }
    else
    {
        Console.WriteLine("Esse jogo vai ser decidido no critério de desempate \"gols fora\".");
        if (golForaPartida2 > golForaPartida1)
        {
            Console.WriteLine("O time A se classificou com o critério de desempate.");
        }
        else if (golForaPartida1 > golCasaPartida2)
        {
            Console.WriteLine("O time B se classificou com o critério de desempate.");
        }
        else
        {
            Console.WriteLine("O jogo não pode ser decidido pelo critério anterior, então será decidido pelo critério de classificação. Por esse critério, o time A será o time que avançaram para a próxima fase.");
        }
    }
}