// See https://aka.ms/new-console-template for more information

/* 5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
 * (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
 * consumido para percorrê-la (medido em l).
 * */

Console.WriteLine("Exercício 5: Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um \nautomóvel (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de \nccombustível onsumido para percorrê-la (medido em l).");

float dist, comb, rend;

Console.Write("Digite a distância total (em Km) percorrida pelo veículo: ");
dist = float.Parse(Console.ReadLine());

Console.Write("Digite o consumo de combustível (em l) do veículo no percurso realizado acima: ");
comb = float.Parse(Console.ReadLine());

rend = dist / comb;

Console.Write("O rendimento do carro é de " + rend + " Km/l");

