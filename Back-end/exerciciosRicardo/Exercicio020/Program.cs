// See https://aka.ms/new-console-template for more information

/* 
 * Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”.
 **/

int chance1, chance2, chance3, valRandom;
Random r = new Random();

valRandom = (int) r.Next(0, 100);

Console.WriteLine("=================================================================================");
Console.WriteLine("                                   ADIVINHAÇÃO                                   ");
Console.WriteLine("=================================================================================");
Console.Write("Sua primeira chance de adivinha o valor de 0 a 100, faça a tentativa: ");
chance1 = int.Parse(Console.ReadLine());
Console.WriteLine();

if (chance1 == valRandom)
{
    Console.WriteLine("Parabéns, você acertou o número.\n");
}
else if (chance1 > valRandom)
{

    Console.Write("O número digitado foi maior, tente digitar um número menor.\n\n" +
                  "Sua segunda chance de adivinha o valor de 0 a 100, faça a tentativa: ");
    chance2 = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (chance2 == valRandom)
    {
        Console.WriteLine("Parabéns, você acertou o número.\n");
    }
    else if (chance2 > valRandom)
    {
        Console.Write("O número digitado foi maior, tente digitar um número menor.\n\n" +
                      "Sua segunda chance de adivinha o valor de 0 a 100, faça a tentativa: ");
        chance3 = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (chance3 == valRandom)
        {
            Console.WriteLine("Parabéns, você acertou o número.\n");
        }
        else
        {
            Console.WriteLine("Que pena, você não conseguiu dessa vez.\n");
        }
    }
    else
    {
        Console.Write("O número digitado foi menor, tente digitar um número maior.\n\n" +
                      "Sua segunda chance de adivinha o valor de 0 a 100, faça a tentativa: ");
        chance3 = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (chance3 == valRandom)
        {
            Console.WriteLine("Parabéns, você acertou o número.\n");
        }
        else
        {
            Console.WriteLine("Que pena, você não conseguiu dessa vez.\n");
        }
    }
}
else
{
    Console.Write("O número digitado foi menor, tente digitar um número maior.\n\n" +
                  "Sua segunda chance de adivinha o valor de 0 a 100, faça a tentativa: ");
    chance2 = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (chance2 == valRandom)
    {
        Console.WriteLine("Parabéns, você acertou o número.\n");
    }
    else if (chance2 > valRandom)
    {
        Console.Write("O número digitado foi maior, tente digitar um número menor.\n\n" +
                      "Sua segunda chance de adivinha o valor de 0 a 100, faça a tentativa: ");
        chance3 = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (chance3 == valRandom)
        {
            Console.WriteLine("Parabéns, você acertou o número.\n");

        }
        else
        {
            Console.WriteLine("Que pena, você não conseguiu dessa vez.\n");

        }
    }
    else
    {
        Console.Write("O número digitado foi menor, tente digitar um número maior.\n\n" +
                  "Sua segunda chance de adivinha o valor de 0 a 100, faça a tentativa: ");
        chance3 = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (chance3 == valRandom)
        {
            Console.WriteLine("Parabéns, você acertou o número.\n");
        }
        else
        {
            Console.WriteLine("Que pena, você não conseguiu dessa vez.\n");
        }
    }
}

Console.WriteLine("=================================================================================");
Console.WriteLine("                                 GABARARITO: {0}                                 ", valRandom);
Console.WriteLine("=================================================================================");

