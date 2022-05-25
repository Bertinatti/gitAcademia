// See https://aka.ms/new-console-template for more information

// instanciando o namespace onde está a classe
using ClasseLivro;

// imprime a mensagem na tela, lê o que o usuário digitado e cria uma variável para salvar esse valor
Console.Write("Digite o título do livro: ");
string titulo = Console.ReadLine();
Console.Write("Digite o autor do livro: ");
string autor = Console.ReadLine();
Console.Write("Digite o número de páginas do livro: ");
int paginas = int.Parse(Console.ReadLine());
Console.Write("Digite o ano de publicação do livro: ");
int ano = int.Parse(Console.ReadLine());
Console.Write("Digite o número da edição do livro: ");
int edicao = int.Parse(Console.ReadLine());

// instancia o objeto da classe Livro e preenche os parâmetros do construtor
Livro l = new Livro(titulo, autor, paginas, ano, edicao);

// chama o método para apresentar as informações do livro
l.apresentaInfoLivro();