// See https://aka.ms/new-console-template for more information

/*
 * 7.	Os dois primeiros números da sequência de Fibonacci são 0 e 1. Os próximos números dessa 
 * sequência podem ser calculados como sendo a soma dos dois números anteriores. Os primeiros
 * números de Fibonacci são: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … Escreva um algoritmo 
 * que leia um número pelo teclado N, e então mostre os N primeiros números da sequência de Fibonacci.
 **/

// declaração das variáveis
int n, fibonacci, num1, num2;

// atribuição dos valores
fibonacci = 0;
num1 = 0;
num2 = 0;

// imprime a mensagem na tela, lê o valor digitado pelo usuário e salva na variável
Console.Write("Digite o valor de elementos da sequência de Fibonacci: ");
n = int.Parse(Console.ReadLine());
Console.WriteLine();

// efetua a sequência de fibonnaci
for (int i = 1; i <= n; i++)
{
    if (i == 1)
    {
        num2 = 0;
    }
    else if(i == 2)
    {
        num2 = 1;
    }
    else
    {
        num2 = num1;
    }
    num1 = fibonacci;
    fibonacci = num1 + num2;
    Console.Write("{0}...", fibonacci);
}