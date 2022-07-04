// See https://aka.ms/new-console-template for more information

/* 
 * Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.
 * Ajuste o exercício para que mostre os valores informados em ordem crescente.
 **/

// declaração da variáveis
int[] num = new int[4];
int[] numMaior = new int[4];
int c = 0;
double media;

// imprime na tela a mensagem, lê os valores digitados e salva na matriz
Console.Write("Digite o primeiro valor: ");
num[0] = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
num[1] = int.Parse(Console.ReadLine());
Console.Write("Digite o terceiro valor: ");
num[2] = int.Parse(Console.ReadLine());
Console.Write("Digite o quarto valor: ");
num[3] = int.Parse(Console.ReadLine());

// efetua o cálculo da média
media = (double)(num[0] + num[1] + num[2] + num[3]) / 4;

// efetua a checagem dos que são maiores que a média
Console.WriteLine("São maiores que a média {0:F2}.", media);
for (int i = 0; i < num.Length; i++)
{
    if (num[i] > media)
    {
        numMaior[c] = num[i];
        c++;
    }
    else
    {
        // faz nada
    }
}

Array.Sort(numMaior);

// efetua a exibição dos valores maiores que a média na forma crescente
for (int i = 0; i < numMaior.Length; i++)
{
    if(numMaior[i] > 0)
    {
        Console.WriteLine("{0}...", numMaior[i]);
    }
    else
    {
        // faz nada
    }
}


