// See https://aka.ms/new-console-template for more information

/*
 * 17. Apresentar os quadrados dos números inteiros de 15 a 200.
 **/

// declaração da variáveis
int exp, num;

// atribuição de valor ao expoente
exp = 2;

// repetição para exibir o quadrado dos números inteiros positivo de 15 a 200.
for (int i = 15; i <= 200 ; i++)
{
    num = i;
    Console.WriteLine("O quadrado do {0} é: {1:F2}\n", num, Math.Pow(num, exp));
}
