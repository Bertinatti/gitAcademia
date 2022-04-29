// See https://aka.ms/new-console-template for more information

/*
* 7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo,
* o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
* Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.
* */

Console.WriteLine("Exercício 7: Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo,\n" + "o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas.\n" + "Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.");

int numVend;
float salFixo, totVendas, percVendas, salTotal;

Console.WriteLine("----------------------------------------------");
Console.WriteLine("                  BEM-VINDO                   ");
Console.WriteLine("----------------------------------------------");
Console.Write("Digite o seu númerdo (código) de vendedor: ");
numVend = int.Parse(Console.ReadLine());
Console.Write("Digite o seu salário fixo: ");
salFixo = float.Parse(Console.ReadLine());
Console.Write("Digite o valor total das vendas: ");
totVendas = float.Parse(Console.ReadLine());
Console.Write("Digite o percentual (0-100) de comissão : ");
percVendas = float.Parse(Console.ReadLine());

salTotal = salFixo + totVendas * (percVendas / 100);
Console.WriteLine("----------------------------------------------");
Console.WriteLine("Vendedor número: " + numVend);
Console.WriteLine($"Esse mês você receberá: R$ {salTotal:F2}");
Console.WriteLine("----------------------------------------------");
