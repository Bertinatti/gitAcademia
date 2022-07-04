// See https://aka.ms/new-console-template for more information

/* 
 * Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.
 **/

int[] num = new int [4];
double media;

Console.Write("Digite o primeiro valor: ");
num[0] = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
num[1] = int.Parse(Console.ReadLine());
Console.Write("Digite o terceiro valor: ");
num[2] = int.Parse(Console.ReadLine());
Console.Write("Digite o quarto valor: ");
num[3] = int.Parse(Console.ReadLine());

media = (double)(num[0] + num[1] + num[2] + num[3]) / 4;


Console.WriteLine("São maiores que a média {0:F2}.", media);
for (int i = 0; i < num.Length; i++)
{
    if (num[i] > media)
    {
        Console.Write("{0}... ", num[i]);
    }
    else
    {
        // faz nada
    }
}


