// See https://aka.ms/new-console-template for more information

/*
 * Escreva a seqüência de atribuições, em forma de programa em C# e no 
 * Visual Studio, para trocar entre si os valores de duas variáveis A e B.
 */

Console.WriteLine("Exercício 3: Escreva a seqüência de atribuições,\n " + "em forma de programa em C# e no Visual Studio, para trocar entre \n" + "si os valores de duas variáveis A e B");

string s1, s2, tmp;

Console.Write("Digite uma frase qualquer: ");
s1 = Console.ReadLine();

Console.Write("Digite outra frase qualquer: ");
s2 = Console.ReadLine();

Console.WriteLine("O conteúdo da variável s1 é: " + s1);
Console.WriteLine("O conteúdo da variável s2 é: " + s2);

Console.WriteLine("Processo de alternância de valores...");

tmp = s1;
s1 = s2;
s2 = tmp;

Console.WriteLine("O conteúdo da variável s1 é: " + s1);
Console.WriteLine("O conteúdo da variável s2 é: " + s2);
