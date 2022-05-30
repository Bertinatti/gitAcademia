// See https://aka.ms/new-console-template for more information

/*
 * 11) Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos. Calcule e escreva o percentual que cada um 
 * representa em relação ao total de eleitores.
 **/

Console.WriteLine("Exercício 11:\n" +
    "Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos. \n" +
    "Calcule e escreva o percentual que cada um representa em relação ao total de eleitores.\n");

int totEleitores, votosBrancos, votosNulos, votosValidos, somaVotos; /* Variaveis para o total de eleitores, votos em branco, nulo e válidos**/
float percBrancos, percNulos, percValidos;

Console.WriteLine("------------------------------------------------------");
Console.WriteLine("                 PERCENTUAL ELEITORAL                 ");
Console.WriteLine("------------------------------------------------------");
Console.Write("Digite o números de eleitores do município: ");
totEleitores = int.Parse(Console.ReadLine());
Console.Write("Digite o números de votos em branco: ");
votosBrancos = int.Parse(Console.ReadLine());
Console.Write("Digite o números de votos nulos: ");
votosNulos = int.Parse(Console.ReadLine());
Console.Write("Digite o números de votos válidos: ");
votosValidos = int.Parse(Console.ReadLine());

somaVotos = votosBrancos + votosNulos + votosValidos;

if (totEleitores == somaVotos)
{
    percBrancos = (votosBrancos * 100) / totEleitores;
    percNulos = (votosNulos * 100) / totEleitores;
    percValidos = (votosValidos * 100) / totEleitores;

    Console.WriteLine("------------------------------------------------------");
    Console.WriteLine("O percentual de votos brancos é: " + percBrancos + "%.");
    Console.WriteLine("O percentual de votos nulos é: " + percNulos + "%.");
    Console.WriteLine("O percentual de votos válidos é: " + percValidos + "%.");
    Console.WriteLine("De um total de: " + totEleitores + " votos.");
    Console.WriteLine("------------------------------------------------------");
}
else
{
    Console.WriteLine("------------------------------------------------------");
    Console.WriteLine("O total de eleitores não bate com os valores\n" +
        "parciais, confira a contagem!");
    Console.WriteLine("------------------------------------------------------");
}

