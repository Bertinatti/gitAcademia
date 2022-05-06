// See https://aka.ms/new-console-template for more information

/* 
 * Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
 * O programa deve exibir se a hora digitada está ou não válida. 
 * Lembre que usaremos o padrão de hora com 24h, de 0 a 23.
 **/

// declaração das variáveis
int horas, minutos;

// imprime as mensagens na tela e faz a leitura dos valores digitados para serem salvos nas variáveis
Console.Write("Digite as horas: ");
horas = int.Parse(Console.ReadLine());
Console.Write("Digite os minutos: ");
minutos = int.Parse(Console.ReadLine());

// efetua a checagem para verificar se o formato de hora:minuto digitado é um formato válido
if ((horas >= 0 && horas <= 23) && (minutos >= 0 && minutos <= 59 ))
{
    Console.WriteLine("A hora digitadade é valida!\n" +
                      "\tSão: {0:00}:{1:00}", horas, minutos);
}
else
{
    Console.WriteLine("O valor não é uma valor válido para as horas no formato permitido.");
}
