// See https://aka.ms/new-console-template for more information

/*
 * 6.	Faça um programa que leia um número n e imprima se ele é primo ou não. 
 * (um número primo tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!)
 **/

// declaração das variáveis
int num, contaDivisor;

// atribuição do valor a variável de contagem
contaDivisor = 0;

// imprime a mensagem na tela, lê o valor digitado pelo usuário e salva na variável
Console.Write("Digite um número: ");
num = int.Parse(Console.ReadLine());
Console.WriteLine();

// repetição para verificar quantos são os divisores do número digitado
for(int i = 1; i <= num; i++)
{
    if (num % i == 0)
    {
        contaDivisor++;
    }
}

// verifica se ele é primo ou não
if(contaDivisor == 2)
{
    Console.WriteLine("O número é primo.\n");
}
else
{
    Console.WriteLine("O número não é primo.\n");
}

// imprime a mensagem de finalização do processo
Console.WriteLine("Finalizando processo...");
