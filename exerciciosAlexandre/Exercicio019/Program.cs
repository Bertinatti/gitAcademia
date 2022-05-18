// See https://aka.ms/new-console-template for more information

/*
 * 19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
 * coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 
 * 
 * a) média do salário da população;
 * b) média do número de filhos;
 * c) maior salário;
 * d) percentual de pessoas com salário até R$ 100,00.
 * O final da leitura de dados se dará com a entrada de um salário negativo.
 **/

// declaração das variáveis
int numFilhos, contagemPop, contagemFilhos, contagemSalario100;
double salario,somaSalario, mediaSalario, maiorSalario, mediaFilhos, percentualSalario100;

// atribuição dos valores
contagemPop = 0;
contagemFilhos = 0;
salario = 0;
maiorSalario = 0;
somaSalario = 0;
contagemSalario100 = 0;

// repetição infinita que se quebra ao ser digitado um salário negativo 
while (true)
{
    // imprime a mensagem na tela, lê o valor digitado e salva na variável
    Console.Write("Digite o seu salário: ");
    salario = double.Parse(Console.ReadLine());
    Console.WriteLine();

    // validação do salário e quebra do laço de repetição infinita
    if(salario < 0)
    {
        break;
    }

    // imprime a mensagem na tela, lê o valor digitado e salva na variável
    Console.Write("Digite a quantidade de filhos: ");
    numFilhos = int.Parse(Console.ReadLine());
    Console.WriteLine();

    // efetua as contagens e somas
    contagemPop++;
    contagemFilhos += numFilhos;
    somaSalario += salario;

    // verifica se o salário digitado é maior que o salvo na variável
    if(salario > maiorSalario)
    {
        maiorSalario = salario;
    }

    // verifica se o salário está na faixa de 0 a 100
    if(salario >= 0 && salario <= 100)
    {
        contagemSalario100++;
    }

}

// calcula a média salarial
mediaSalario = (double) somaSalario / contagemPop;

// calcula a média de filhos
mediaFilhos = (double) contagemFilhos / contagemPop;

// calcula o percentual de pessoas com salário de até R$100
percentualSalario100 = (double) (contagemSalario100 * 1) / contagemPop;

// imprime na tela um menu com as informações relativas aos dados inseridos
Console.WriteLine("=====================================================================\n" +
                  "                      DADOS PARA A PREFEITURA:                       \n" +
                  "=====================================================================\n" +
                  "[1] - Média dos salários:                               {0:C}\n" +
                  "[2] - Média do número de filhos:                        {1:F2}\n" +
                  "[3] - Maior salário:                                    {2:C}\n" +
                  "[4] - Percentual de pessoas com salário até R$ 100:     {3:0%}\n" +
                  "=====================================================================", mediaSalario, mediaFilhos, maiorSalario, percentualSalario100);
