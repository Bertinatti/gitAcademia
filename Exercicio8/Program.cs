// See https://aka.ms/new-console-template for more information

/* 8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
 * A fórmula da conversão é F=(9*C+160)/5.
 * */

Console.WriteLine("Exercício 8: Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit.\n" + "A fórmula da conversão é F=(9*C+160)/5.");

float tempC, tempF;
Console.WriteLine("--------------------------------------------");
Console.WriteLine("          CONVERSOR DE TEMPERATURA          ");
Console.WriteLine("--------------------------------------------");
Console.Write("Digite a temperatura em Celsius (ºC): ");
tempC = float.Parse(Console.ReadLine());

tempF = (9 * tempC + 160) / 5;

Console.WriteLine("--------------------------------------------");
Console.WriteLine($"A temperatura é: {tempF:F2} ºF");
Console.WriteLine("--------------------------------------------");
