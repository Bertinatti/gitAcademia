// See https://aka.ms/new-console-template for more information

/* 
 * Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.
 **/

// declaração das variáveis
double val1, val2, val3;

// imprime a mensagem na tela, lê o valor digitado e salva na variável
Console.Write("Digite o primeiro valor: ");
val1 = double.Parse(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
val2 = double.Parse(Console.ReadLine());
Console.Write("Digite o terceiro valor: ");
val3 = double.Parse(Console.ReadLine());

// efetua a primeira parte condicional, vendo se existe um valor "único" maior que os outros 
if (val1 > val2 && val1 > val3)
{
    Console.WriteLine("O valor {0} é o maior entre os digitados.", val1);
}
else if (val2 > val1 && val2 > val3)
{
    Console.WriteLine("O valor {0} é o maior entre os digitados.", val2);
}
else if (val3 > val1 && val3 > val2)
{
    Console.WriteLine("O valor {0} é o maior entre os digitados.", val3);
}

// se a primeira parte nao for verdade, entra em um outro aninhamento para ver se são todos iguais ou se a dois valores iguais entre os maiores
else
{
    if (val1 == val2 && val1 == val3)
    {
        Console.WriteLine("Os valores digitados são todos iguais.");
    }
    else if (val1 > val2 && val1 == val3)
    {
        Console.WriteLine("O primerio valor digitado {0} e o terceiro valor {1} são iguais e também são os maiores valores digitados.", val1, val3);
    }
    else if (val1 > val3 && val1 == val2)
    {
        Console.WriteLine("O primerio valor digitado {0} e o segundo valor {1} são iguais e também são os maiores valores digitados.", val1, val2);
    }
    else
    {
        Console.WriteLine("O segundo valor digitado {0} e o terceiro valor {1} são iguais e também são os maiores valores digitados.", val2, val3);
    }
}
