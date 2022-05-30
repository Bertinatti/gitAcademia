// See https://aka.ms/new-console-template for more information

/*
 * 16) Calculadora que recebe dois números e realiza as operações matemáticas.
 **/

// declaração das variáveis
double num1, num2, res;
int opcUser;

// imprime a mensagem na tela, lê o que o usuário digitou e salva na variável
Console.Write("Digite o primeiro valor: ");
num1 = double.Parse(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
num2 = double.Parse(Console.ReadLine());
Console.WriteLine("=======================================\n" +
                  "               CALCULADORA             \n" +
                  "=======================================\n" +
                  "[1] - Adição." +
                  "[2] - Subtração." +
                  "[3] - Divisão." +
                  "[4] - Multiplicação." +
                  "[5] - Potenciação." +
                  "=======================================");
opcUser = int.Parse(Console.ReadLine());

// resolvendo com if else
if (opcUser == 1)
{
    res = num1 + num2;
    Console.WriteLine("O resultado da adição: {0} + {1} = {2}", num1, num2, res);
}
else if (opcUser == 2)
{
    res = num1 - num2;
    Console.WriteLine("O resultado da subtração: {0} - {1} = {2}", num1, num2, res);
}
else if (opcUser == 3)
{
    res = num1 / num2;
    Console.WriteLine("O resultado da divisão: {0} / {1} = {2}", num1, num2, res);
}
else if (opcUser == 4)
{
    res = num1 * num2;
    Console.WriteLine("O resultado da multiplicação: {0} x {1} = {2}", num1, num2, res);
}
else if (opcUser == 5)
{
    res = Math.Pow(num1, num2);
    Console.WriteLine("O resultado da potenciação: {0} ^ {1} = {2}", num1, num2, res);
}
else
{
    Console.WriteLine("Valor inválido!");
}

/* resolvendo com switch
switch (opcUser)
{
    case 1:
        res = num1 + num2;
        Console.WriteLine("O resultado da adição: {0} + {1} = {2}", num1, num2, res);
        break;
    case 2:
        res = num1 - num2;
        Console.WriteLine("O resultado da subtração: {0} - {1} = {2}", num1, num2, res);
        break;
    case 3:
        res = num1 / num2;
        Console.WriteLine("O resultado da divisão: {0} / {1} = {2}", num1, num2, res);
        break;
    case 4:
        res = num1 * num2;
        Console.WriteLine("O resultado da multiplicação: {0} x {1} = {2}", num1, num2, res);
        break;
    case 5:
        res = Math.Pow(num1, num2);
        Console.WriteLine("O resultado da potenciação: {0} ^ {1} = {2}", num1, num2, res);
        break;
    default:
        Console.WriteLine("Valor inválido!");
        break;
}
**/
