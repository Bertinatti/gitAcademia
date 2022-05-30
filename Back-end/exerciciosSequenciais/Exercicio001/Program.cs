// See https://aka.ms/new-console-template for more information

/*
 * 1) Escreva um programa em C# e no Visual Studio para 
 * calcular a média aritmética entre dois números quaisquer.
 * */

Console.WriteLine("Exercício 1: Escreva um programa em C# e no Visual \n" + "Studio para calcular a média aritmética entre dois \n " + "números quaisquer");

float n1, n2, media;

Console.Write("Digite o primeiro número: ");
n1 = float.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
n2 = float.Parse(Console.ReadLine());

media = (n1 + n2) / 2;

Console.WriteLine("A média aritmética dos números digitados é: " + media);
