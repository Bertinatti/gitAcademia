// See https://aka.ms/new-console-template for more information

/* 
 * 6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
 * ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
 * Ao final, mostre a idade digitada.
 **/

int idade;
bool repSair = true;

while (repSair == true)
{
    Console.Write("Digite a sua idade: ");
    idade = int.Parse(Console.ReadLine());
    Console.WriteLine();

    // verificar se a idade é igual ou menor a 0, se sim, fará com que o laço de repetição se repita até que seja digitado um idade válida
    if(idade <= 0)
    {
        Console.WriteLine("Idade inválida, digite um idade maior que 0.\n");
    }
    // caso a idade seja valida, fechará o laço de repetição
    else
    {
        repSair = false;
    }
}

// imprime a mensagem de saída
Console.WriteLine("Saindo...");
