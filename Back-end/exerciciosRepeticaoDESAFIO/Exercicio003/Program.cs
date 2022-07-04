// See https://aka.ms/new-console-template for more information

/*
 * 3.	Dado um limite inferior e superior, calcule a soma de todos os números pares contidos
 * nesse intervalo.
 **/

// declaração das variáveis
int inferior, superior, somaPar;

// atribuição de valor
somaPar = 0;

// imprime a mensagem na tela, lê o que foi digitado pelo usuário e salva na variável
Console.Write("Digite o valor inferior: ");
inferior = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Digite o valor superior: ");
superior = int.Parse(Console.ReadLine());
Console.WriteLine();

// verificar se os valores digitados são maiores ou menores que o outro para fazer uma repetição correta para o cálculo
if (inferior < superior)
{
    // repetição do número inferior digitado até o número superior digitado
    for (int i = inferior; i <= superior; i++)
    {
        // efetua a soma dos números se ele for par
        if (i % 2 == 0)
        {
            somaPar += i;
        }
    }

    // imprime na tela a soma dos números pares
    Console.WriteLine("A soma dos números pares de {0} a {1} é {2}.\n", inferior, superior, somaPar);

}
// verificar se os valores digitados são maiores ou menores que o outro para fazer uma repetição correta para o cálculo
else if(inferior > superior)
{
    // repetição do número inferior digitado até o número superior digitado
    for (int i = inferior; i >= superior; i--)
    {
        // efetua a soma dos números se ele for par
        if (i % 2 == 0)
        {
            somaPar += i;
        }
    }

    // imprime na tela a soma dos números pares
    Console.WriteLine("A soma dos números pares de {0} a {1} é {2}.\n", inferior, superior, somaPar);

}
// por final, verifica que os números são iguais
else
{
    //imprime a mensagem na tela
    Console.WriteLine("O valor inferior e o superior são iguais.\n");

    // verifica se os números são pares
    if(inferior % 2 == 0 && superior % 2 == 0)
    {
        Console.WriteLine("Os valores {0} e {1} são pares.\n", inferior, superior);
    }
    // por fim, verifica que os números são ímpares
    else
    {
        Console.WriteLine("Os valores {0} e {1} são ímpares.\n", inferior, superior);
    }
}


