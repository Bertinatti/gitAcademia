// See https://aka.ms/new-console-template for more information

/*
 * 9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
 * o zoológico num determinado dia, imprimindo:
 * Quantas pessoas tem entre 1 e 3 filhos.
 * Quantas pessoas tem entre 4 e 7 filhos.
 * Quantas pessoas tem mais de 8 filhos.
 * Quantas pessoas não tem filhos.
 **/

// declaração das variáveis
int quantidade, quantidadeA, quantidadeB, quantidadeC, quantidadeD;

// a variável quantidadeA será o contador para a faixa: 1 a 3 filhos
quantidadeA = 0;

// a variável quantidadeB será o contador para a faixa: 4 a 7 filhos
quantidadeB = 0;

// a variável quantidadeC será o contador para a faixa: mais de 8 filhos
quantidadeC = 0;

// a variável quantidadeD será o contador para a faixa: sem filhos
quantidadeD = 0;

// repetição para adicionar a resposta das pessoas e efetuar as contagens das determinas faixas
for (int i = 0; i < 30; i++)
{
    Console.Write("Quantos filhos você tem? ");
    quantidade = int.Parse(Console.ReadLine());

    // essa checagem está considerando que todo valor de zero ao infinito negativo é um valor para o quantitativo de quem não tem filho, uma consideração que poderia ser diferente se utilizasse a validação dos dados
    if(quantidade <= 0)
    {
        quantidadeD++;
    }
    else if(quantidade>=1 && quantidade <= 3)
    {
        quantidadeA++;
    }
    else if(quantidade>=4 && quantidade <= 7)
    {
        quantidadeB++;
    }
    else
    {
        quantidadeC++;
    }
}

// menu para exibição do resultado da contagem das determinadas faixas
Console.WriteLine("====================================================\n" +
                  "                      CONTAGEM                      \n" +
                  "====================================================\n" +
                  "[1] - Pessoas com 1 a 3 filhos:                 {0}\n" +
                  "[2] - Pessoas com 4 a 7 filhos:                 {1}\n" +
                  "[3] - Pessoas com mais de 8 filhos:             {2}\n" +
                  "[4] - Pessoas sem filhos:                       {3}\n" +
                  "====================================================",quantidadeA, quantidadeB, quantidadeC, quantidadeD);