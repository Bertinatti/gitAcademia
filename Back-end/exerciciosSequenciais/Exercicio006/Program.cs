// See https://aka.ms/new-console-template for more information

/* 6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B,
 * isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
 * de IPI (única) a ser acrescentada.
 * */

Console.WriteLine("Exercício 6: Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B,\nisto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem de IPI(única) a ser \nacrescentada.");

int codA, codB, quantA, quantB;
float valUnA, valUnB, valFA, valFB, porcA, porcB;

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("                     PARAFUSO A                   ");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Digite os dados do parafuso A.");
Console.Write("Código: ");
codA = int.Parse(Console.ReadLine());
Console.Write("Quantidade: ");
quantA = int.Parse(Console.ReadLine());
Console.Write("Valor unitário: R$ ");
valUnA = float.Parse(Console.ReadLine());
Console.Write("Porcentagem de IPI (0 - 100): ");
porcA = float.Parse(Console.ReadLine());

valFA = valUnA + valUnA * (porcA / 100);

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("                     PARAFUSO B                   ");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Digite os dados do parafuso B.");
Console.Write("Código: ");
codB = int.Parse(Console.ReadLine());
Console.Write("Quantidade: ");
quantB = int.Parse(Console.ReadLine());
Console.Write("Valor unitário: R$ ");
valUnB = float.Parse(Console.ReadLine());
Console.Write("Porcentagem de IPI: ");
porcB = float.Parse(Console.ReadLine());

valFB = valUnB + (valUnB * (porcB / 100));

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("O valor final do parafuso A com o IPI é: R$ " + valFA);
Console.WriteLine("O valor final do parafuso B com o IPI é: R$ " + valFB);
Console.WriteLine("--------------------------------------------------");

