// See https://aka.ms/new-console-template for more information

/* 
 * Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
 * seu peso ideal, utilizando as seguintes fórmulas:
 * Para homens: (72.7 * h) - 58
 * Para mulheres: (62.1 * h) - 44.7
 **/

// declaração das variáveis
double altura, pesoIdealM, pesoIdealF;
string sexo;

// imprime na tela a mensagem, lê o valor digitado e salva na variável
Console.Write("Digite o valor da sua altura (em m): ");
altura = double.Parse(Console.ReadLine());
Console.Write("Digite o sexo - F (Feminino) ou M (Masculino): ");
sexo = Console.ReadLine().ToUpper();

// efetua a checagem condicional, verifica primeiramente se o sexo foi digitado no formato correto e depois separa por masculino e feminino para realizar a conta
if(sexo == "F" || sexo == "M")
{
    if (sexo == "F")
    {
        pesoIdealF = (62.1 * altura) - 44.7;
        Console.WriteLine("O seu peso ideial é {0:F2}", pesoIdealF);
    }
    else
    {
        pesoIdealM = (72.7 * altura) - 58;
        Console.WriteLine("O seu peso ideial é {0:F2}", pesoIdealM);
    }
}
else
{
    Console.WriteLine("Sexo digitado não está no formato permitido.");
}

/* Jeito simplificado de fazer (sem condicional)
 * 
 * // imprime a mensagem na tela e lê o valor digitado no terminal para salvar na variavel altura
 * Console.Write("Digite o valor da sua altura (em m): ");
 * altura = double.Parse(Console.ReadLine());
 * 
 * pesoIdealF = (62.1 * altura) - 44.7;
 * pesoIdealM = (72.7 * altura) - 58;
 * 
 * Console.WriteLine("Se for mulher, seu peso ideal é {0:F2}\n" +
                     "Se for homem, seu peso ideal é {1:F2}", pesoIdealM, pesoIdealF);
**/

