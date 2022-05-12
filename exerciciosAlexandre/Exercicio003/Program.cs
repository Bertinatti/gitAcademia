// See https://aka.ms/new-console-template for more information

/* 
 * 3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
 * Se o usuário digitar 0 o programa em VS deve parar. 
 * Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.
 **/

// declaração das variáveis
int num, contaPrimo;

// atribuição do valor 0 para a contagem dos números que dividem a variável num
contaPrimo = 0;

// laço de repetição que se quebra qnd digitado 0 com uma condição que quebra ela no instante que se digitar o 0
do
{
    // imprime a mensagem na tela, lê o valor digitado e salva na variável
    Console.Write("Digite o número: ");
    num = int.Parse(Console.ReadLine());

    // checa se o valor digitado foi 0, se positivo quebra o laço de repetição
    if(num == 0)
    {
        Console.WriteLine();
        break;
    }

    // repetição para efetuar a divisão e ver quantos são os números que divivem a variável num
    for (int i = 1; i <= num; i++)
    {
        if(num % i == 0)
        {
            contaPrimo++;
        }
    }

    // quebra uma linha
    Console.WriteLine();

    // faz a checagem dos números para ver se são pares ou ímpares e primos ou não primos
    if(num % 2 == 0 && contaPrimo == 2)
    {
        Console.WriteLine("O número {0} é um número PAR e PRIMO.\n", num);
    }
    else if (num % 2 != 0 && contaPrimo == 2)
    {
        Console.WriteLine("O número {0} é um número ÍMPAR e PRIMO.\n", num);
    }
    else if (num % 2 == 0 && contaPrimo > 2)
    {
        Console.WriteLine("O número {0} é um número PAR e NÃO É PRIMO.\n", num);
    }
    else
    {
        Console.WriteLine("O número {0} é um número ÍMPAR e NÃO É PRIMO.\n", num);
    }

    // efetua a zeragem da contagem para não ter acumulo do valor digitado anteriormente 
    contaPrimo = 0;

} while (num != 0);

// imprime a mensagem de saída do programa
Console.WriteLine("Saindo do programa...");
