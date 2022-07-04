// See https://aka.ms/new-console-template for more information

/* 
 * 11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
 * a média aritmética da turma e a quantidade de alunos da turma. Usar como flag a nota 12.
 **/

// declaração das variáveis
double nota, notaAlta, notaBaixa,somaNotas, mediaNotas;
int quantidadeAlunos;
string resposta;

// atribuição de valores
notaAlta = 0;
notaBaixa = 12;
quantidadeAlunos = 0;
somaNotas = 0;

// repetição infinita que só se quebrará quando for digita n, não ou nao
while (true)
{
    Console.Write("Digite a nota: ");
    nota = double.Parse(Console.ReadLine());
    Console.WriteLine();

    if (nota > notaAlta)
    {
        notaAlta = nota;
    }

    if (nota < notaBaixa)
    {
        notaBaixa = nota;
    }

    somaNotas += nota;

    quantidadeAlunos++;

    Console.Write("Deseja cadastrar mais uma nota(S/N)? ");
    resposta= Console.ReadLine().ToUpper();
    Console.WriteLine();

    if(resposta == "N" || resposta == "NÃO" || resposta == "NAO")
    {
        break;
    }
}

// efetua a media das notas
mediaNotas = (double) somaNotas / quantidadeAlunos;

// imprime o menu com os resultados das notas
Console.WriteLine("=====================================================\n" +
                  "                        NOTAS                        \n" +
                  "=====================================================\n" +
                  "[1] - Nota mais alta:                        {0}\n" +
                  "[2] - Nota mais baixa:                       {1}\n" +
                  "[3] - Média aritmética:                      {2:F2}\n" +
                  "[4] - Número de alunos:                      {3}\n" +
                  "=====================================================", notaAlta, notaBaixa, mediaNotas, quantidadeAlunos);
