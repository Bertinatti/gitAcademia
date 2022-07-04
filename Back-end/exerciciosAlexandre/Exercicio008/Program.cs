// See https://aka.ms/new-console-template for more information

/*
 * 8. Faça um programa em VS que solicite um numero inteiro. 
 * Se o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
 * Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.
 **/

// declaração das variáveis
string recebeNumero, resposta;
int numero;
bool repetir, perguntaSaida, repetirNum;

// atribuição de valores as variáveis de looping ou que esteja sendo atribuídas durante o looping
repetir = true;
perguntaSaida = true;
repetirNum = true;
numero = 0;

// looping principal
while (repetir == true)
{
    // looping com validação do número inteiro
    while (repetirNum == true)
    {
        Console.Write("Digite um número inteiro: ");
        recebeNumero = Console.ReadLine();
        Console.WriteLine();

        if (int.TryParse(recebeNumero, out numero))
        {
            Console.WriteLine("Número inteiro.\n");
            repetirNum = false;
        }
        else
        {
            Console.WriteLine("Número não é inteiro.\n");
        }
    }

    // condicional para checar se é par ou ímpar
    if (numero % 2 == 0)
    {
        Console.WriteLine("O número é PAR.\n");
    }
    else
    {
        Console.WriteLine("O número é ÍMPAR.\n");
    }

    // looping com validação da resposta de saída 
    while (perguntaSaida == true)
    {
        Console.Write("Deseja repetir o programa(S/N)? ");
        resposta = Console.ReadLine().ToUpper();
        Console.WriteLine();

        if (resposta == "S" || resposta == "N")
        {
            if (resposta == "S")
            {
                repetirNum = true;
                break;
            }
            else
            {
                perguntaSaida = false;
                repetir = false;
            }
        }
        else
        {
            Console.WriteLine("Digite uma resposta válida, S para sim e N para não.\n");
        }
    }  
}