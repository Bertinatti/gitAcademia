// See https://aka.ms/new-console-template for more information

/*
 * 2.	Imprima uma tabela de conversão de polegadas para centímetros, de 1 a 20. Considere que
 * Polegada = Centímetro * 2,54.
 **/

// declaração das variáveis
double centimetro, polegada;

// atribuição do valor de conversão
polegada = 2.54;

// imprime o cabeçalho da tabela
Console.WriteLine("========================================");
Console.WriteLine("||    POLEGADAS    ||   CENTÍMETROS   ||");

// repetição realizar a conversão de 1 a 20
for (int i = 1; i <= 20; i++)
{
    // efetua o cálculo da conversão e imprime na tela com uma pequena formatação
    centimetro = (double) i * polegada;
    Console.WriteLine("||      {0:00.00}      ||      {1:00.00}      ||", i, centimetro);
}

// fecha a tabela
Console.WriteLine("========================================");
