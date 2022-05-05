// See https://aka.ms/new-console-template for more information

/* 
 * Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
 * Mostrar na tela qual dos professores tem o maior salário total.
 **/

// declaração das variáveis
int quantHorasA, quantHorasB;
string nomeA, nomeB;
double precoAulaA, precoAulaB, salTotA, salTotB;

// pequeno menu para o professor A
Console.Write("Digite o seu nome professor: ");
nomeA = Console.ReadLine();
Console.Write("{0}, quantas aulas você deu esse mês? ", nomeA);
quantHorasA = int.Parse(Console.ReadLine());
Console.Write("{0}, quanto será pago por cada hora de trabalho? ", nomeA);
precoAulaA = double.Parse(Console.ReadLine());
salTotA = (double) quantHorasA * precoAulaA;
Console.WriteLine();

// pequeno menu para o professor B
Console.Write("Digite o seu nome professor: ");
nomeB = Console.ReadLine();
Console.Write("{0}, quantas aulas você deu esse mês? ", nomeB);
quantHorasB = int.Parse(Console.ReadLine());
Console.Write("{0}, quanto será pago por cada hora de trabalho? ", nomeB);
precoAulaB = double.Parse(Console.ReadLine());
salTotB = (double) quantHorasB * precoAulaB;
Console.WriteLine();

// testagem lógica para ver qual é o maior salário entre os dois 
if (salTotA > salTotB)
{
    Console.Write("{0}, esse mês seu salário foi maior que o do {1}.", nomeA, nomeB);
    Console.WriteLine();
}
else if (salTotB < salTotA)
{
    Console.Write("{0}, esse mês seu salário foi maior que o do {1}.", nomeB, nomeA);
    Console.WriteLine();
}
else
{
    Console.Write("{0} e {1}, esse mês o salário de vocês será igual.", nomeA, nomeB);
    Console.WriteLine();
}
