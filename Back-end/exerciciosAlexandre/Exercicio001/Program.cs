// See https://aka.ms/new-console-template for more information

/*
 * 1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
 * (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
 * Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.
 * 
 * Exemplo:
 * Digite um número inteiro positivo: -8
 * Valor incorreto!
 * Digite um número inteiro positivo: 8
 * Numero digitado: 8
 * Números inteiros pares entre 1 e 8: 2, 4, 6.
 **/

// declara das variáveis
bool rep = true;
int num = 0;

// efetua a repetição equanto a variável rep for true
while (rep == true)
{
    // imprime a mensagem na tela, lê o valor digitado para adicionar na variável criada
    Console.Write("Digite um valor inteiro positivo: ");
    num = int.Parse(Console.ReadLine());

    // se o número for positivo, ou seja, maior que zero
    if (num > 0)
    {
        rep = false;
    }

    // se negativo ou
    else
    {
        Console.WriteLine("\nO número digitado não é válido, digite um número POSITIVO!\n");
    }
}

// efetua a exibição dos números pares entre 1 ao número digitado
Console.WriteLine("\nOs números PARES entre 1 e {0} são: \n", num);
for (int i = 1; i <= num; i++)
{
    if (i % 2 == 0)
    {
        Console.Write("{0}... ", i);
    }
}

// pula uma linha, apenas visual
Console.WriteLine("");


