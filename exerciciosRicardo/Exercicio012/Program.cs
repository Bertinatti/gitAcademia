// See https://aka.ms/new-console-template for more information

/*
 * Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
 * número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
 * R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
 * armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
 * No final do processamento, exibir o salário total e o salário excedente do operário.
 **/

// declaração das variáveis
int codigo, numeroHoras, numeroHorasExtra, numeroHorasNormais;
double salario, extra;

// impressão das mensagens na tela e leitura dos valores digitados
Console.Write("Digite o seu código: ");
codigo = int.Parse(Console.ReadLine());
Console.Write("Digite o número de horas trabalhadas: ");
numeroHoras = int.Parse(Console.ReadLine());

// checagem da condicional de horas
if (numeroHoras > 50)
{
    numeroHorasExtra = numeroHoras - 50;
    numeroHorasNormais = numeroHoras - numeroHorasExtra;
    extra = numeroHorasExtra * 20.00;
    salario = (numeroHorasNormais * 10.00) + extra;
}
else
{
    numeroHorasExtra = 0;
    extra = 0;
    salario = (numeroHoras * 10.00) + extra;
}

Console.Write("Esse mês seu salário total será de {0:C} com o adicional de horas extras sendo igual a {1:C}.", salario, extra);
