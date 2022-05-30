// See https://aka.ms/new-console-template for more information

/* 9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
* do que ou igual às duas prestações, que devem ser iguais, inteiras e as maiores possíveis. 
* Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
* se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
* Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
* da entrada e das duas prestações, de acordo com as regras acima. 
* Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
* conseqüente pagamento dos boletos das duas prestações.
* */

Console.WriteLine("Exercício 9:\n" +
    "Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior\n" +
    "do que ou igual às duas prestações, que devem ser iguais, inteiras e as maiores possíveis.\n" +
    "Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00;\n" +
    "se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.\n" +
    "Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor\n" +
    "da entrada e das duas prestações, de acordo com as regras acima.\n" +
    "Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o\n" +
    "conseqüente pagamento dos boletos das duas prestações.");

float valorMerc, entrada, parc, calcParc;

Console.WriteLine("--------------------------------------------");
Console.WriteLine("            CARRINHO DE COMPRAS             ");
Console.WriteLine("--------------------------------------------");
Console.Write("Digite o valor da mercadoria: R$ ");
valorMerc = float.Parse(Console.ReadLine());

calcParc = valorMerc % 10;
parc = (valorMerc - calcParc) / 3;
entrada = parc + calcParc;

Console.WriteLine("--------------------------------------------");
Console.WriteLine($"O valor paga na entrada é: R$ {entrada:F2}");
Console.WriteLine($"O valor das parcelas são: R$ {parc:F2}");
Console.WriteLine("--------------------------------------------");
