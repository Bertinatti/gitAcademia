// See https://aka.ms/new-console-template for more information

/* 
 * 12. Apresentar o total da soma dos cem primeiros números inteiros.
 **/

// declaração da variável soma e atribuição de valor
int soma = 0;

// repetição para efetuar a somatório dos números inteiros de 1 a 100
for (int i = 1; i <= 100; i++)
{
    soma += i;
}

// imprime na tela o resultado da somatória
Console.WriteLine("A soma dos cem primeiros números inteiros positivos é: {0}", soma);
