// See https://aka.ms/new-console-template for more information

/* 
 * 16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
 * multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
 * (N*3; N*3*3; N*3*3*3; etc).
 **/

// declaração das variáveis
int num;
double multiplicacao;

// repetição sem fim para validar o dado digitado
while (true)
{
    Console.Write("Digite um valor menor ou igual a 50: ");
    num = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if(num <= 50)
    {
        break;
    }
    else
    {
        Console.WriteLine("Número não válido, digite um número válido.\n");
    }
}

// atribuição temporaria do valor para a multiplicação
multiplicacao = num;

// repetição sem fim para efetuar a conta do num*3 e exibindo o resultado a cada etapa, sendo a etapa caracterizada como a multiplicação do valor por 3
while (true)
{
    multiplicacao *= 3;

    if(multiplicacao >= 250)
    {
        break;
    }
    else
    {
        Console.WriteLine("O valor da multiplicação do número digitado por 3 é: {0:F2}\n", multiplicacao);
    }
}



