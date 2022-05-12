// See https://aka.ms/new-console-template for more information

/* 
 * 2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
 * informar um outro número. Caso positivo, o programa em VS deve ser repetido.
 * 
 * Exemplo:
 * 
 * Digite um número inteiro positivo: 8
 * Numero digitado: 8
 * Números inteiros pares entre 1 e 8: 2, 4, 6.
 * 
 * Deseja informar outro número (s/n)? S
 * 
 * Digite um número inteiro positivo: 12
 * 
 * Numero digitado: 20
 * 
 * Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.
 * 
 * Deseja informar outro número (s/n)? N
 **/

// declara das variáveis
bool rep = true;
int num = 0;
bool repSair = true;
string resp = "S";

do
{
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
            repSair = true;
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

    // efetua a quebra de linha
    Console.WriteLine("\n");

    // efetua a repetição até que a pessoa digite N, com válidação de dado inserido para S e N
    while (repSair == true)
    {
        // imprime a mensagem na tela, lê o valor digitado e salva na variável
        Console.Write("Desejar digitar outro número(S/N)? ");
        resp = (string) Console.ReadLine().ToUpper();

        // faz a validação do dado digitado pelo usuário - S ou N
        if(resp == "S" || resp == "N")
        {
            // caso digite sim, faz a troca da repetição de cima para que não fique em um looping infinito, porém, se digitar não essa troca não é utilizado e o programa apenas se encerra
            repSair = false;
            rep = true;
            Console.WriteLine();
        }
        else
        {
            // dado não foi validado e é pedido ao usuário que digite um valor válido
            Console.WriteLine("\nEntrada não válida para sair, digite S para sim e N para não.\n");
        }
    }
 // condição final de repetição do DoWhile
} while (resp != "N");

Console.WriteLine("Saindo...");