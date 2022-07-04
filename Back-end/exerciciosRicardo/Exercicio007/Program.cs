// See https://aka.ms/new-console-template for more information

/* 
 * Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
 * O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
 * exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.
 **/

// declaração da variáveis
string fraseDigitada, palavraPesquisa;

// imprime a mensagem na tela, lê o valor digitado no console e salva na variável
Console.Write("Digite a frase: ");
fraseDigitada = Console.ReadLine();
Console.Write("Digite uma palavra para pesquisar na frase: ");
palavraPesquisa = Console.ReadLine();

// efetua a checagem condiconal para verificar se a frase digitada contém a palavra de pesquisa digitada
if (fraseDigitada.ToUpper().Contains(palavraPesquisa.ToUpper()))
{
    Console.WriteLine("A frase digitada contém a palavra \"{0}\" nela.", palavraPesquisa);
}
else
{
    Console.WriteLine("A frase digitada não contém a palavra \"{0}\" nela.", palavraPesquisa);
}
