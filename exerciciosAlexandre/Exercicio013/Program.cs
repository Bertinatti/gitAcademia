// See https://aka.ms/new-console-template for more information

/* 
 * 13. Elaborar um programa que apresente o somatório dos valores pares existentes 
 * entre 1 e 500.
 **/

// declaração da variável e atribuição de valor
int somaPar = 0;

// efetua um laço de repetição para a somátória
for (int i = 1; i <= 500; i++)
{
    if (i % 2 == 0)
    {
        somaPar += i;
    }
}

// imprime a mensagem com o valor da somatória dos números pares
Console.WriteLine("A somatória dos números pares de 1 a 500 é: {0}", somaPar);
