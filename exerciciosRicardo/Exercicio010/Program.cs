// See https://aka.ms/new-console-template for more information

/* 
 * Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
 * O programa deve mostrar os dados do atleta mais novo e mais alto.
 **/

// declaração das variáveis
string nomeA, nomeB;
int idadeA, idadeB;
double alturaA, alturaB;

// dados do atleta A
Console.WriteLine("---------ATLETA A--------");
Console.Write("Digite seu nome: ");
nomeA = Console.ReadLine();
Console.Write("Digite a sua idade: ");
idadeA = int.Parse(Console.ReadLine());
Console.Write("Digite a sua altura: ");
alturaA = double.Parse(Console.ReadLine());
Console.WriteLine();

// dados do atleta B
Console.WriteLine("---------ATLETA B--------");
Console.Write("Digite seu nome: ");
nomeB = Console.ReadLine();
Console.Write("Digite a sua idade: ");
idadeB = int.Parse(Console.ReadLine());
Console.Write("Digite a sua altura: ");
alturaB = double.Parse(Console.ReadLine());
Console.WriteLine();

// efetua a checagem pra ver qual é o atleta mais novo e mais alto (satisfaça as duas condições)
if (idadeA<idadeB && alturaA > alturaB)
{
    Console.WriteLine("{0} é o atleta mais novo e mais alto, com {1} anos de idade e {2:F2} m de altura.", nomeA, idadeA, alturaA);
}
else if (idadeB < idadeA && alturaB > alturaA )
{
    Console.WriteLine("{0} é o atleta mais novo e mais alto, com {1} anos de idade e {2:F2} m de altura.", nomeB, idadeB, alturaB);
}
else
{
    Console.WriteLine("Nenhum atleta atende as duas condições, ser o mais novo e mais alto.");
}
