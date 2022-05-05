// See https://aka.ms/new-console-template for more information

/* 
 * 6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
 * O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
 * O cálculo do imc = peso / (altura * altura)
 * 
 * IMC 
 * 
 * menor que 18                -> baixo peso
 * maior que 18 e menor que 25 -> peso normal
 * maior que 25 e menor que 30 -> sobrepeso
 * maior que 30 e menor que 35 -> obesidade
 * maior que 35                -> obesidade grau sério
 * 
 **/

// declaração das variáveis
string nome;
double altura, peso, imc;

// imprissão das mensagens na tela e leitura dos valores digitados pelo usuário
Console.Write("Digite o seu nome: ");
nome = Console.ReadLine().ToUpper();
Console.Write("Digite a sua altura (em m): ");
altura = double.Parse(Console.ReadLine());
Console.Write("Digite o seu peso (em Kg): ");
peso = double.Parse(Console.ReadLine());

// efetuando o cálculo do IMC
imc = peso / (altura * altura);

// checagem para ver em qual categoria o IMC calculado se encaixa
if (imc < 18)
{
    Console.WriteLine("{0}, você está abaixo do peso e seu IMC é de {1:F2}.", nome, imc);
}
else if (imc >= 18 && imc < 25)
{
    Console.WriteLine("{0}, você está no peso normal e seu IMC é de {1:F2}.", nome, imc);
}
else if (imc >= 25 && imc < 30)
{
    Console.WriteLine("{0}, você está com sobrepeso e seu IMC é de {1:F2}.", nome, imc);
}
else if (imc >= 30 && imc < 35)
{
    Console.WriteLine("{0}, você está com obesidade e seu IMC é de {1:F2}.", nome, imc);
}
else
{
    Console.WriteLine("{0}, você está com obesidade de grau sério e seu IMC é de {1:F2}.", nome, imc);
}
