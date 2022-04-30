// See https://aka.ms/new-console-template for more information

/*
 * 13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
 * preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
 * vendidas pelo vendedor, calcule e mostre: o salário do empregado.
 * */

Console.WriteLine("Exercício 13: ");

int numBic;
double salMin, salVend, precoBic, totVendas;

Console.WriteLine("-----------------------------------------------");
Console.WriteLine("              CÁLCULO DE COMISSÃO              ");
Console.WriteLine("-----------------------------------------------");
Console.Write("Digite o valor do salário mínino atual: ");
salMin = double.Parse(Console.ReadLine());
Console.Write("Digite o preço de custo das bicicletas: ");
precoBic = double.Parse(Console.ReadLine());
Console.Write("Digite o total de bicicletas vendidas: ");
numBic = int.Parse(Console.ReadLine());

totVendas = precoBic * numBic;
salVend = (2 * salMin) + (totVendas * 0.15); /* 15% é 15/100 ou 0.15 **/

Console.WriteLine("-----------------------------------------------");
Console.WriteLine($"Esse mês seu salário será de: R$ {salVend:F2}");
Console.WriteLine("-----------------------------------------------");