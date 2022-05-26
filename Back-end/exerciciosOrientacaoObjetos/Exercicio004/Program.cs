// See https://aka.ms/new-console-template for more information

/*
 * #4
 * Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções. Dessa forma, crie um programa em C# que represente
 * uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, faça uma classe que contenha os atributos (privados) posição x, posição y (do asteroide em
 * um plano cartesiano), tamanho do asteroide (1 a 10), velocidade do asteroide (1 a 5) e energia (1 a 5). Para esses atributos privados, gerar os métodos de acesso
 * (propriedades getter e setter). Além disso, implementar 3 construtores (sobrecarga): um vazio, outro passando todos os parâmetros de um objeto tipo Asteroide, e um 
 * terceiro que constrói um asteroide com posição x e posição y. 
 * O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usuário. Nesse programa principal, construir um método de classe que exiba todos os
 * asteróides da lista.
 * 
 **/

// instanciando o namespace que possui a classe
using Exercicio004;

// declaração das variáveis e da lista do tipo da classe
List<Asteroide> listaAsteroides = new List<Asteroide>();
int posicaoX, posicaoY, tamanho, velocidade, energia;
string resposta = "";

// repetição que se encerra quando o usuário responde "N"
while (resposta != "N")
{
    // imprime a mensagem na tela, lê o valor digitado pelo usuário e salva na variável
    Console.Write("Digite a posição X do asteróide: ");
    posicaoX = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.Write("Digite a posição Y do asteróide: ");
    posicaoY = int.Parse(Console.ReadLine());
    Console.WriteLine();

    // repetição infinita para validar a entrada de dados
    while (true)
    {
        // imprime a mensagem na tela, lê o que o usuário digitou e salva na variável temporaria
        Console.Write("Digite o tamanho do asteróide[1~10]: ");
        int tmpTamanho = int.Parse(Console.ReadLine());
        Console.WriteLine();

        // verifica se o valor digitado é válido, salva na variável e quebra o laço de repetição infinita
        if(tmpTamanho >= 1 && tmpTamanho <= 10)
        {
            tamanho = tmpTamanho;
            break;
        }
        // caso não seja válido, pede para que o usuário digite um valor válido
        else
        {
            Console.WriteLine("O tamanho digitado é inválido.\n");
        }
    }

    // repetição infinita para validar a entrada de dados
    while (true)
    {
        // imprime a mensagem na tela, lê o que o usuário digitou e salva na variável temporaria
        Console.Write("Digite a velocidade do asteróide[1~5]: ");
        int tmpVelocidade = int.Parse(Console.ReadLine());
        Console.WriteLine();

        // verifica se o valor digitado é válido, salva na variável e quebra o laço de repetição infinita
        if (tmpVelocidade >= 1 && tmpVelocidade <= 5)
        {
            velocidade = tmpVelocidade;
            break;
        }
        // caso não seja válido, pede para que o usuário digite um valor válido
        else
        {
            Console.WriteLine("A velocidade digitada é inválida.\n");
        }
    }

    // repetição infinita para validar a entrada de dados
    while (true)
    {
        // imprime a mensagem na tela, lê o que o usuário digitou e salva na variável temporaria
        Console.Write("Digite a energia do asteróide[1~5]: ");
        int tmpEnergia = int.Parse(Console.ReadLine());
        Console.WriteLine();

        // verifica se o valor digitado é válido, salva na variável e quebra o laço de repetição infinita
        if (tmpEnergia >= 1 && tmpEnergia <= 5)
        {
            energia = tmpEnergia;
            break;
        }
        // caso não seja válido, pede para que o usuário digite um valor válido
        else
        {
            Console.WriteLine("A energia digitada é inválida.\n");
        }
    }

    // instancia um objeto da classe Asteroide e usa o construtor para adicionar os atributos
    Asteroide a = new Asteroide(posicaoX, posicaoY, tamanho, velocidade, energia);

    // adiciona o objeto a lista 
    listaAsteroides.Add(a);

    // imprime a mensagem na tela, lê o que o usuário digitou e salva na variável para verificação da repetição
    Console.Write("Digite cadastrar mais uma nota[S/N]? ");
    resposta = Console.ReadLine().ToUpper();
    Console.WriteLine();

    // imprime a mensagem na tela e espera a entrada de alguma tecla
    Console.WriteLine("Pressione uma tecla para continuar.");
    Console.ReadKey();

    // limpa a tela do console
    Console.Clear();

}

// método da classe para exibir os itens na lista
Asteroide.ExibirItensLista(listaAsteroides);

// imprime a mensagem de saída da aplicação
Console.WriteLine("Saindo da aplicação...\n");
