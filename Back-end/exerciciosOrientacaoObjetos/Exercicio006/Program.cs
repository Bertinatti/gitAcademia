// See https://aka.ms/new-console-template for more information

/*
 * #6
 * Crie uma classe para representar um objeto em um Plano Cartesiano. Todo objeto no plano cartesiano
 * tem como atributos 'x' e 'y'. Dessa forma, crie os getters e setter de 'x' e 'y', o construtor básico e
 * um método para exibir um objeto (x,y).
 * Por fim, crie um programa em C# que cadastre 'n' objetos em uma lista (List), um método de que exiba
 * os objetos da lista.
 * 
 **/

using Exercicio006;

List<PlanoCartesiano> listaPlanoCartesiano = new List<PlanoCartesiano>();
int posicaoX, posicaoY;
string resposta = "";

while (resposta != "N")
{
    Console.Write("Digite a posição X do Plano Cartesiano: ");
    posicaoX = int.Parse(Console.ReadLine());
    Console.Write("Digite a posição Y do Plano Cartesiano: ");
    posicaoY = int.Parse(Console.ReadLine());

    PlanoCartesiano p = new PlanoCartesiano(posicaoX, posicaoY);

    listaPlanoCartesiano.Add(p);

    Console.Write("Deseja adicionar mais pontos ao Plano Cartesiano[S/N]?");
    resposta = Console.ReadLine().ToUpper();

    Console.WriteLine("Pressione uma tecla para continuar.");
    Console.ReadKey();

    Console.Clear();
}

PlanoCartesiano.exibeItensLista(listaPlanoCartesiano);