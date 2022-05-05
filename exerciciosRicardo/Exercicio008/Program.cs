// See https://aka.ms/new-console-template for more information

/* 
 * Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
 * Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
 * Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
 * E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
 * total de vendas.
 **/

// declaração das variáveis
int cod;
string nome;
double salBase, totVendas, salTot;

// imprime as mensagens na tela e lê os valores digitados pelo usuário
Console.Write("Digite o seu código: ");
cod = int.Parse(Console.ReadLine());
Console.Write("Digite o seu nome: ");
nome = Console.ReadLine();
Console.Write("Digite o seu salário base: R$ ");
salBase = double.Parse(Console.ReadLine());
Console.Write("Digite o total de vendas: R$ ");
totVendas = double.Parse(Console.ReadLine());

// efetua a verificação das faixas de vendas e encaixa o salario final em função dessa verificação
if (totVendas > 500 && totVendas <= 1000)
{
    salTot = salBase + (totVendas * 0.05);
}
else if (totVendas > 1000 && totVendas <= 5000)
{
    salTot = salBase + (totVendas * 0.07);
}
else if (totVendas > 5000)
{
    salTot = salBase + (totVendas * 0.10);
}
else
{
    salTot = salBase;
}

// imprime a mensagem na tela
Console.WriteLine("{0}, seu salário esse mês será de {1:C}", nome, salTot);
