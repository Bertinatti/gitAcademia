// See https://aka.ms/new-console-template for more information

/*
 * 14) Confere se um número é divisível por 2, 4 e 8.
 **/

// declaração da variável número
int num;

// imprime na tela a mensagem e lê o valor digitado salvando na variável número
Console.Write("Digite o valor do número: ");
num = int.Parse(Console.ReadLine());

// efetua a checagem booleana da variável número
if (num % 2 == 0 & num % 4 == 0 & num % 8 == 0) // verifica se o número é divisível por 2, 4 e 8
{
    Console.WriteLine("Número divisível por 2, 4 e 8."); // imprime a mensagem na tela
}
else if (num % 2 == 0 & num % 4 == 0) // verifica se o número é divisível por 2 e 4 mas não por 8
{
    Console.WriteLine("Número divisível por 2 e 4, mas não por 8."); // imprime a mensagem na tela 
}
else if (num % 2 == 0) // verifica se o número é divisível por 2 mas não por 4 e 8  
{
    Console.WriteLine("Número divisível por 2."); // imprime a mensagem na tela
}
else // caso não seja nenhuma das opções assim 
{
    Console.WriteLine("O número não é divisível por 2, 4 ou 8"); // imprime a mensagem na tela
}

/*
// efetua a checagem booleana da variável número
if (num % 2 == 0 & num % 4 == 0 & num % 8 == 0) // verifica se o número é divisível por 2, 4 e 8
{
    Console.WriteLine("Número divisível por 2, 4 e 8."); // imprime a mensagem na tela
}
else if (num % 2 == 0 & num % 4 == 0 & !(num % 8 == 0) // verifica se o número é divisível por 2 e 4 mas não por 8
{
    Console.WriteLine("Número divisível por 2 e 4, mas não por 8."); // imprime a mensagem na tela 
}
else if (num % 2 == 0 & !(num % 4 == 0) & !(num % 8 == 0)) // verifica se o número é divisível por 2 mas não por 4 e 8  
{
    Console.WriteLine("Número divisível por 2."); // imprime a mensagem na tela
}
else // caso não seja nenhuma das opções assim 
{
    Console.WriteLine("O número não é divisível por 2, 4 ou 8"); // imprime a mensagem na tela
}
**/

/*
// efetua a checagem booleana da variável número
if (num % 8 == 0) // verifica se o número é divisível por 2, 4 e 8
{
    Console.WriteLine("Número divisível por 2, 4 e 8."); // imprime a mensagem na tela
}
else if (num % 4) // verifica se o número é divisível por 2 e 4 mas não por 8
{
    Console.WriteLine("Número divisível por 2 e 4, mas não por 8."); // imprime a mensagem na tela 
}
else if (num % 2) // verifica se o número é divisível por 2 mas não por 4 e 8  
{
    Console.WriteLine("Número divisível por 2."); // imprime a mensagem na tela
}
else // caso não seja nenhuma das opções assim 
{
    Console.WriteLine("O número não é divisível por 2, 4 ou 8"); // imprime a mensagem na tela
}
**/