// See https://aka.ms/new-console-template for more information

/*
 * 18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
 * elevada a um expoente qualquer, ou seja, NM.
 **/

// atribuição das variáveis
bool quebraLooping;
string sair;
double resultado,expoente, numero;

// atribuição global da variável de quebra de looping
quebraLooping = false;

// looping infinito para efetuar o recebimento de dados e o cálculo da potência
while (true)
{
    Console.Write("Digite o valor da base: ");
    numero = double.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.Write("Digite o valor do expoente: ");
    expoente = double.Parse(Console.ReadLine());
    Console.WriteLine();

    resultado = Math.Pow(numero, expoente);
    Console.WriteLine("O número {0} elevado a potência de {1} é: {2:F2}\n", numero, expoente, resultado);

    // looping interno para validar a saída
    while (true)
    {
        Console.Write("Deseja realizar mais uma operação[S/N]? ");
        sair = Console.ReadLine().ToUpper();
        Console.WriteLine();

        if(sair == "N" || sair == "Ñ" || sair == "NAO" || sair == "NÃO")
        {
            quebraLooping = true;
            break; 
        }
    }

    // verificação da saída
    if (quebraLooping == true)
    {
        break;
    }
}

Console.WriteLine("Saindo...");
