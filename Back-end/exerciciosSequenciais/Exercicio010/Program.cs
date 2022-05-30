// See https://aka.ms/new-console-template for more information

/*
* 10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
* para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
* realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
* notas de menor valor fossem distribuídas em menor número mínimo possível. 
* Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00,
* três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
* Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
* de acordo com o critério da “distribuição ótima”.
* */

Console.WriteLine("Exercício 10:\n" +
    "Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo\n" +
    "para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que\n" +
    "realizou o saque. Um possível critério seria o da 'distribuição ótima' no sentido de que as \n" +
    "notas de menor valor fossem distribuídas em menor número mínimo possível. \n" +
    "Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00\n" +
    "três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. \n" +
    "Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas \n" +
    "de acordo com o critério da 'distribuição ótima'.");

int quantNota200, quantNota100, quantNota50, quantNota20, quantNota10, quantNota5, quantNota2, quantNota1;
float valorSaque, valorReais, valorCent, tmp;

Console.Write("Digite o valor do saque: ");
valorSaque = float.Parse(Console.ReadLine());

valorCent = valorSaque % 1;
valorReais = valorSaque - valorCent;

quantNota200 = Convert.ToInt32(valorReais / 200);
tmp = valorReais % 200;
quantNota100 = Convert.ToInt32(tmp / 100);
tmp %= 100;
quantNota50 = Convert.ToInt32(tmp / 50);
tmp %= 50;
quantNota20 = Convert.ToInt32(tmp / 20);
tmp %= 20;
quantNota10 = Convert.ToInt32(tmp / 10);
tmp %= 10;
quantNota5 = Convert.ToInt32(tmp / 5);
tmp %= 5;
quantNota2 = Convert.ToInt32(tmp / 2);
tmp %= 2;
quantNota1 = Convert.ToInt32(tmp / 1);
tmp %= 1;

Console.WriteLine("Serão: " + quantNota200 + " notas de R$ 200,00");
Console.WriteLine("Serão: " + quantNota100 + " notas de R$ 100,00");
Console.WriteLine("Serão: " + quantNota50 + " notas de R$ 50,00");
Console.WriteLine("Serão: " + quantNota20 + " notas de R$ 20,00");
Console.WriteLine("Serão: " + quantNota10 + " notas de R$ 10,00");
Console.WriteLine("Serão: " + quantNota5 + " notas de R$ 5,00");
Console.WriteLine("Serão: " + quantNota2 + " notas de R$ 2,00");
Console.WriteLine("Serão: " + quantNota1 + " notas de R$ 1,00");
Console.WriteLine($"Serão: {valorCent:F2} em centavos");
