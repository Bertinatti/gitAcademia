// See https://aka.ms/new-console-template for more information

/*
 * Escreva um programa em C# e no Visual Studio para calcular a média 
 * aritmética entre quatro números quaisquer.
 */

Console.WriteLine("Exercício 2: Escreva um programa em C# e no Visual Studio \n" + "para calcular a média aritmética entre quatro números quaisquer.");

float n1, n2, n3, n4, media;

Console.Write("Digite o primeiro número: ");
n1 = float.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
n2 = float.Parse(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
n3 = float.Parse(Console.ReadLine());

Console.Write("Digite o quarto número: ");
n4 = float.Parse(Console.ReadLine());

media = (n1 + n2 + n3 + n4) / 4;

Console.WriteLine("A média aritmética dos quatros números digitados é: " + media);