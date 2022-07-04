// See https://aka.ms/new-console-template for more information

/* 
 * 10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
 * Número de pessoas do sexo masculino.
 * Número de pessoas do sexo feminino.
 * Número de pessoas com idade inferior a 30 anos.
 * Número de pessoas com idade superior a 60 anos.
 * Média de idade das mulheres.
 **/

// declaração das variáveis
int idade, sexoMasculino, sexoFeminino, idadeInferior30, idadeSuperior60, somaIdade;
double mediaIdade;
string nome, sexo;

// atribuição de valor as variáveis
sexoMasculino = 0;
sexoFeminino = 0;
somaIdade = 0;
idadeInferior30 = 0;
idadeSuperior60 = 0;

// repetição para as 50 pessoas
for (int i = 0; i < 50; i++)
{
    Console.Write("Digite o seu nome: ");
    nome = Console.ReadLine();
    Console.Write("Digite o sexo(M/F):");
    sexo = Console.ReadLine().ToUpper();
    Console.Write("Digite a sua idade: ");
    idade = int.Parse(Console.ReadLine());

    if(sexo == "M" || sexo == "MASCULINO")
    {
        sexoMasculino++;
    }
    else if(sexo == "F" || sexo == "FEMININO")
    {
        sexoFeminino++;
        somaIdade += idade;
    }
    // essa checagem representa os usuários que irão inserir um sexo não valido
    else
    {
        // faz nada
    }

    if (idade < 30)
    {
        idadeInferior30++;
    }
    else if (idade > 60)
    {
        idadeSuperior60++;
    }
    // essa checagem representa a faixa entre 30 e 60 anos, que não está sendo contemplada nas outras checagens
    else
    {
        // faz nada
    }
    Console.WriteLine();
}

// efetua o cálculo da média da idade das mulheres
mediaIdade = (double) somaIdade / sexoFeminino;

// imprime o menu da contagem
Console.WriteLine("========================================================\n" +
                  "                         CONTAGEM                       \n" +
                  "========================================================\n" +
                  "[1] - Pessoas do sexo masculino:               {0}\n" +
                  "[2] - Pessoas do sexo feminino:                {1}\n" +
                  "[3] - Pessoas com idade inferior a 30 anos:    {2}\n" +
                  "[4] - Pessoas com idade superior a 60 anos:    {3}\n" +
                  "[5] - A média das idades das mulhres é:        {4} anos\n" +
                  "========================================================", sexoMasculino, sexoFeminino, idadeInferior30, idadeSuperior60, mediaIdade);
