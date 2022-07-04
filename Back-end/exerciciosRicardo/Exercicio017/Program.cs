// See https://aka.ms/new-console-template for more information

/* 
 * Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
 * formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
 * os lados iguais), isosceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).
 **/

// declaração das variáveis
double ladoA, ladoB, ladoC;

// imprime a mensagem na tela, lê o valor digitado pelo usuário e salva na variável
Console.Write("Digite o valor do lado A do triângulo: ");
ladoA = double.Parse(Console.ReadLine()); // os valores digitados serão adimensionais para efeito de checagem
Console.Write("Digite o valor do lado B do triângulo: ");
ladoB = double.Parse(Console.ReadLine()); // os valores digitados serão adimensionais para efeito de checagem
Console.Write("Digite o valor do lado C do triângulo: ");
ladoC = double.Parse(Console.ReadLine()); // os valores digitados serão adimensionais para efeito de checagem

// efetua a checagem para ver se os valores digitados podem formar um triângulo
if((ladoA <= ladoB + ladoC) && (ladoB <= ladoA + ladoC) && (ladoC <= ladoA + ladoB) )
{
    // retorno uma mensagem de confirmação para o usuário e em seguida efetua uma nova condicional
    Console.WriteLine("Os lados digitados podem formar um triângulo.");

    // caso seja equilátero
    if (ladoA == ladoB && ladoB == ladoC)
    {
        Console.WriteLine("O triângulo digitado é um triângulo equilátero.");
    }

    // caso seja isosceles 
    else if ((ladoA == ladoB && ladoB != ladoC) || (ladoA == ladoC && ladoC != ladoB) || (ladoB == ladoC && ladoC != ladoA))
    {
        Console.WriteLine("O triângulo digitado é um triângulo isosceles.");
    }

    // caso seja escaleno
    else
    {
        Console.WriteLine("O triângulo digitado é um triângulo escaleno.");
    }
}

// retorno uma mensagem de negação ao usuário
else
{
    Console.WriteLine("Os lados digitados {0:F2}, {1:F2} e {2:F2} não podem formar um triângulo.", ladoA, ladoB, ladoC);
}

