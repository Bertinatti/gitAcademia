// See https://aka.ms/new-console-template for more information

/* 
 * Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: Área do triangulo = (base * altura) / 2; 
 * Teste se a base ou a altura digitada não foi igual a zero. 
 **/

// declaração das variáveis
double areaTriangulo, baseTriangulo, altTriangulo;

// impressão das mensagens na tela do terminal e leitura dos valores digitados
Console.Write("Digite a base do triângulo (em m): ");
baseTriangulo = double.Parse(Console.ReadLine());
Console.Write("Digite a altura do triângulo (em m): ");
altTriangulo = double.Parse(Console.ReadLine());

// checagem da condicional para realizar os passos seguintes do programa
if (baseTriangulo != 0 & altTriangulo != 0)
{
    areaTriangulo = (baseTriangulo * altTriangulo) / 2;
    Console.WriteLine("O triângulo de base {0:F2} m e altura {1:F2} m tem área igual a {2:F4} m²", baseTriangulo, altTriangulo, areaTriangulo);
}
else
{
    Console.WriteLine("Algum dos valores digitados foi zero, digite valores diferentes de zero!");
}
