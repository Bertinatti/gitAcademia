// See https://aka.ms/new-console-template for more information

/*
 * 5.	Escreva um programa em C# que gera números entre 1000 e 1999 e mostra aqueles que divididos
 * por 11 dão resto 5.
 **/

// repetição de 1000 a 1999
for (int i = 1000; i <= 1999; i++)
{
    // verifica se o número da repetição divido por 11 resta 5, caso positivo exibe o número na tela
    if (i % 11 == 5)
    {
        Console.WriteLine(i);
    }
}
