// See https://aka.ms/new-console-template for more information

/* 
 * Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 
 **/

// declaração da variável
int num;

// imprime a mensagem na tela e lê o valor digitado no terminal
Console.Write("Digite o número: ");
num = int.Parse(Console.ReadLine());

// checagem da condicional para verificar se é par ou ímpar
if (num % 2 == 0)
{
    Console.Write("O valor digitado é PAR!");
}
else
{
    Console.Write("O valor digitado é ÍMPAR!");
}

