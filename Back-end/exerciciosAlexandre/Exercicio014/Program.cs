// See https://aka.ms/new-console-template for more information

/* 
 * 14. Mostrar as potências de 2 variando de 0 a 10.
 **/

// declaração da variável e atribuição de valor
int potencia = 2;

// repetição para exibir o número 2 elevado ao expoente i (0 a 10)
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"2 ^ {i} = {Math.Pow(potencia, i)}");
}
