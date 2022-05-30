// See https://aka.ms/new-console-template for more information

/*
 * 4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
 * forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.
 * */

Console.Write("Exercício 4:  Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA \n e imprima na forma AAAAMMDD e AAMMDD.Note que o dia, o mês e o ano devem ser lidos em \nvariáveis diferentes.");

int d, m, a;

Console.Write("Digite o dia (no formato DD): ");
d = int.Parse(Console.ReadLine());

Console.Write("Digite o mês (no formato MM): ");
m = int.Parse(Console.ReadLine());

Console.Write("Digite o ano (no formato AAAA): ");
a = int.Parse(Console.ReadLine());

DateTime dateN = DateTime.Parse("" + d + "/" + m + "/" + a);
Console.WriteLine("A data formatada em DD/MM/AAAA é: " + (String.Format("{0:dd/MM/yyyy}", dateN)));

DateTime dateI = DateTime.Parse("" + a + "/" + m + "/" + d);
Console.WriteLine("A data formatada em AA/MM/DD é: " + (String.Format("{0:yy/MM/dd}", dateI)));