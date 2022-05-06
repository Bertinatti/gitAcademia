// See https://aka.ms/new-console-template for more information

/* 
 * Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
 * da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
 * e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
 * Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.
 **/

// declaração das variáveis
double areaPintada, precoTot, numLatas, litros;

// imprime a mensagem na tela, lê o valor digitado pelo usuário e salva na variável
Console.Write("Digite a quantia de metros quadrados que serão pintados: ");
areaPintada = double.Parse(Console.ReadLine());

// efetua o calculo para descobrir a quantidade de litros
litros = areaPintada / 3;

// efetua o calculo para descobrir a quantidade de latas
numLatas = Math.Ceiling(litros / 18);
 
// efetua o calculo para descobrir o preço final da compra
precoTot = numLatas * 80.00;

// imprime na tela a mensagem com a quantiddade de latas e o preço final da compra
Console.Write("Caro cliente, para essa pintura você precisará de {0:00} latas de tintas de 18 litros totalizando um valor de {1:C}.", numLatas, precoTot);
