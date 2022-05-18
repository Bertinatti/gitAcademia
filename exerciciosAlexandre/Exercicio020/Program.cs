// See https://aka.ms/new-console-template for more information

/*
 * 20. Foi realizada uma pesquisa de algumas características físicas da população de uma 
 * certa região, a qual coletou os seguintes dados referentes a cada habitante para 
 * serem analisados:
 * - sexo (masculino e feminino)
 * - cor dos olhos (azuis, verdes ou castanhos)
 * - cor dos cabelos ( louros, castanhos, pretos)
 * - idade 
 * 
 * Faça um algoritmo que determine e escreva: 
 * 
 * - a maior idade dos habitantes
 * - a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
 * e que tenham olhos verdes e cabelos louros.
 * O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.
 **/

string sexo, corOlhos, corCabelos;
int idade, maiorIdade, contagemFeminino;

maiorIdade = 0;
contagemFeminino = 0;

while (true)
{
    Console.Write("Digite o seu sexo:\n" +
        " - Masculino\n" +
        " - Feminino\n");
    sexo = Console.ReadLine().ToUpper();
    Console.WriteLine();

    Console.WriteLine("Digite a cor dos seus olhos:\n" +
        " - Azul\n" +
        " - Verde\n" +
        " - Castanho\n");
    corOlhos = Console.ReadLine().ToUpper();
    Console.WriteLine();

    Console.WriteLine("Digite a cor do cabelo:\n" +
        " - Loiro\n" +
        " - Castanho\n" +
        " - Preto");
    corCabelos = Console.ReadLine().ToUpper();
    Console.WriteLine();

    Console.WriteLine("Digite a sua idade: ");
    idade = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if(idade == -1)
    {
        break;
    }

    if (idade > maiorIdade)
    {
        maiorIdade = idade;
    }

    if(sexo == "FEMININO" && idade >= 18 && idade <= 35 && corOlhos == "VERDE" && corCabelos == "LOIRO")
    {
        contagemFeminino++;
    }
}

Console.WriteLine("=========================================\n" +
                  "              DADOS FINAIS:              \n" +
                  "=========================================\n" +
                  "[1] - Maior idade:                {0}\n" +
                  "[2] - Contagem de mulheres:       {1}\n" +
                  "=========================================", maiorIdade, contagemFeminino);
