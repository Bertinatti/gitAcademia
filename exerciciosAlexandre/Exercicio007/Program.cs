// See https://aka.ms/new-console-template for more information

/*
 * 7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
 * A cada solicitação, teste se o usuário informou um valor válido. 
 * Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
 * informe que ele está incorreto e saia do programa em VS. 
 * Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
 * informe que está errada e saia. Se estiver correta, solicite o salário. 
 * Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
 * Se estiver correto, mostre todos os valores lidos.
 **/

string nome;
int idade, contNum;
double salario;

contNum = 0;

do
{

    Console.Write("Digite seu nome: ");
    nome = Console.ReadLine();

    foreach (char c in nome)
    {
        if (c >= '0' && c <= '9')
        {
            contNum++;
        }
    }

    if (nome == null || nome == " " || contNum > 0)
    {
        break;
    }
    else
    {
        Console.Write("Digite a sua idade: ");
        idade = int.Parse(Console.ReadLine());

        if(idade <= 0)
        {
            break;
        }
        else
        {
            Console.Write("Digite o seu salário: R$ ");
            salario = double.Parse(Console.ReadLine());

            if (salario <= 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("=================================================\n" +
                                  "                   BEM-VINDO                     \n" +
                                  "=================================================\n" +
                                  "[1] - Nome:        {0}\n" +
                                  "[2] - Idade:       {1} anos\n" +
                                  "[3] - Salário:     {2:C}\n" +
                                  "=================================================", nome, idade, salario);
                break;
            }
        }
    }
} while (true);