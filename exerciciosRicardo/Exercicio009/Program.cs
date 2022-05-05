// See https://aka.ms/new-console-template for more information

/* 
 * Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
 * diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
 * Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
 * Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.
 **/

// declaração da matriz para receber os valores
double[] glicemia = new double[3];

// efetua o looping para receber os 3 valores e fazer a checagem a cada impressão
for (int i = 0; i < glicemia.Length; i++)
{
    Console.Write("Digite o valor da glicemia em jejum: ");
    glicemia[i] = double.Parse(Console.ReadLine());

    if(glicemia[i] < 65)
    {
        Console.WriteLine("Você está correndo o risco de ter uma hipoglicemia.");
    }
    else if (glicemia[i] > 250)
    {
        Console.WriteLine("Você está correndo o risco de ter uma hiperglicemia.");
    }
    else
    {
        Console.WriteLine("Está tudo bem, mantenha assim.");
    }
}
