// See https://aka.ms/new-console-template for more information

/*
 * #5
 * Crie uma classe para representar um item de cenário, com os atributos privados de:
 *  * descrição (string),
 *  * data de criação (date - https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0) e
 *  * altura (float). 
 *  
 *  Crie os métodos públicos necessários para sets e gets, o construtor básico e também um método para imprimir 
 *  todos dados de um item de cenário. 
 *  Por fim, crie um método para calcular a quanto tempo o item foi criado, além de um programa em C# para testar
 *  a classe criada.
 *  
 **/

// instancia do namespace onde está  a classe
using Exercicio005;

// criação de uma data generica apens para testagem
DateTime data = new DateTime(2022,02,12);

// criação do objeto Item e atribuição de valores com o método construtor
Item i = new Item("Descrição", data, 100.8f);

// chamada do método para imprimir os valores na tela
i.ImprimeDados();

// atribuição de valor a variável que conta os dias da criação do item 
int dias = i.RetornaDias();

// imprime a mensagem na tela com a quantidade de dias desde a criação do item
Console.WriteLine("São {0} dias desde a criação do item.", dias);
