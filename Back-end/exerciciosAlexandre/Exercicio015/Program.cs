// See https://aka.ms/new-console-template for more information

/* 
 * 15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
 * ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
 * Considerar nota 7,0 como mínima para aprovação.
 **/

// declaração das variáveis
double[] nota = new double[4];
double mediaPonderada;

// laço de repetição para receber as 4 notas na matriz nota
for (int i = 0; i < 4; i++)
{
    Console.Write("Digite a {0}ª nota: ", i+1);
    nota[i] = double.Parse(Console.ReadLine());
}

// efetua o cálculo da média ponderada
mediaPonderada = (double) ((nota[0] * 2) + (nota[1] * 1) + (nota[2] * 2) + (nota[3] * 4)) / 9;

// imprime o resultado da média ponderada
Console.WriteLine("A média ponderada é: {0:F2}", mediaPonderada);