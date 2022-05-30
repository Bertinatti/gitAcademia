// See https://aka.ms/new-console-template for more information

/*
 * 12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
 * marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido 
 * dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.
 * 
 * Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 
 * 
 * Média do consumo = Total quilometragem/ quantidade de combustível gasto
 * 
 * Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)
 * 
 * */

Console.Write("Exercício 12:\n" +
    "Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do\n" +
    "combustível é de R$6,90, escreva um algoritmo para ler a marcação do odômetro (marcador de\n" +
    "quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível\n" +
    "gasto e o valor total (R$) recebido dos passageiros. Calcule e escreva a média do consumo em\n" +
    "Km/l e o lucro líquido do dia.\n");

double kmInicio, kmFinal, numLitros, kmTotal, consumoComb, valCorridas, valComb, valLucro;

Console.WriteLine("----------------------------------------------------------------------");
Console.WriteLine("                          RENDIMENTO DIÁRIO                           ");
Console.WriteLine("----------------------------------------------------------------------");
Console.Write("Digite a marcação inicial do odômetro: ");
kmInicio = double.Parse(Console.ReadLine());
Console.Write("Digite a marcação final do odômetro: ");
kmFinal = double.Parse(Console.ReadLine());
Console.Write("Digite a quantia de combustível gasto (em l): ");
numLitros = double.Parse(Console.ReadLine());
Console.Write("Digite a quantia total recebida pelas corridas: ");
valCorridas = double.Parse(Console.ReadLine());

kmTotal = kmFinal - kmInicio;
consumoComb = kmTotal / numLitros;
valComb = kmTotal * 6.90;
valLucro = valCorridas - valComb;

Console.WriteLine("----------------------------------------------------------------------");
Console.WriteLine($"O consumo diário foi de: {consumoComb:F2} Km/l.");
Console.WriteLine($"O lucro final foi de: R$ {valLucro:F2}");
Console.WriteLine("----------------------------------------------------------------------");