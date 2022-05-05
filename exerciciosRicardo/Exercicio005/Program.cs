// See https://aka.ms/new-console-template for more information

/* Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” se a média das duas notas for maior ou igual a 7,0. 
 * Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final. 
 * Se esta média for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve escrever “Reprovado”.
 **/

// declaração das variáveis 
double nota1, nota2, notaExame, mediaFinal, mediaExame;

// imprime na tela e lê o valor digitado para salvar na variável
Console.Write("Digite a primeira nota: ");
nota1 = double.Parse(Console.ReadLine());
Console.Write("Digite a segunda nota: ");
nota2 = double.Parse(Console.ReadLine());

// cálculo da média do período normal
mediaFinal = (nota1 + nota2) / 2;

// checagem das condicionais de aprovado, exame ou reprovado
if (mediaFinal >= 7.00)
{
    Console.Write("Parabéns, você foi APROVADO!");
}
else
{
    Console.Write("Digite a nota do exame: ");
    notaExame = double.Parse(Console.ReadLine());
    mediaExame = (mediaFinal + notaExame) / 2;
    if(mediaExame >= 5.00)
    {
        Console.Write("Parabéns, você foi APROVADO no exame!");
    }
    else
    {
        Console.Write("Você foi REPROVADO no exame!");
    }
}

