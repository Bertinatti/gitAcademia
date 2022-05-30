// See https://aka.ms/new-console-template for more information

/* 
 * 15) Ler dois números e verificar se são iguais ou diferentes.
 **/

// declaração das variáveis
double num1, num2;

// imprimindo as mensagens na tela e lendo os valores para salvar nas variáveis
Console.Write("Digite o valor do primeiro número: ");
num1 = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do segundo número: ");
num2 = double.Parse(Console.ReadLine());

// efetuando a testagem lógica pedida no enunciado
if (num1 == num2)
{
    Console.WriteLine("Os valores {0} e {1} são iguais!", num1, num2);
}
else
{
    Console.WriteLine("Os valores {0} e {1} são diferentes!", num1, num2);
}
