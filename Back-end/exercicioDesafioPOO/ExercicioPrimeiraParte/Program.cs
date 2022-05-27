// See https://aka.ms/new-console-template for more information

/*
 * Trabalho para entender e aplicar a teoria de Orientação a Objetos (terceirização), uso adequado de Listas e Arquivos.
 * Além disso, aplicar a ideia de menu de opções.
 * 
 * Construir um programa em VS que gerencie veículos em garagem. O programa deve ter um menu de operação. Os dados dos
 * veículos devem ser persistidos em arquivo e manipulados em uma lista dinâmica em memória.
 * Os dados dos veículos são : string placa; DateTime dataHoraEntrada.
 * 
 * MENU
 * 1 - Cadastrar veículo entrando na garagem
 * 2 - Exibir veículos cadastrados
 * 3 - Sair
 * Opção: 
 * 
 * Observações: Criar a classe Veiculo (placa, dataHoraEntrada); usar as classes List, StreamReader, StreamWriter, DateTime
 * Use como base de dados o arquivo 'garagem.dat'.
 **/

// instancia o namespace onde se encontra as Classes
using ExercicioPrimeiraParte;

// declara a variável e cria a lista
int opcao = 0;
List<Veiculo> listaVeiculos = new List<Veiculo>();

// chama o metodo conectaArquivo(lista) da classe de utilidade
Util.conectaArquivo(listaVeiculos);

// efetua a repetição até que seja pedido pra sair
do
{
    // utilizado o metodo para exibir o menu e salva o retorno na variável opcao
    opcao = Util.mostrarMenu();
    // utiliza o valor do retorno e a lista de veiculos para retornar a opção que o usuário escolheu no menu
    Util.resultadoMenu(opcao, listaVeiculos);

    // imprime a mensagem na tela e espera o pressionamento de uma tecla
    Console.WriteLine("Pressione uma tecla para continuar.");
    Console.ReadKey();

} while (opcao != 3);
