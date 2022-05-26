// See https://aka.ms/new-console-template for more information

/*
 * Os quatro pilares do paradigma de Orientação a Objetos são:
 * 
 * A - Sequenciamento, Procedimentos, Bibliotecas e Herança.
 * B - Herança, Polimorfismo, Classes e Objetos.
 * C - Classes, Atributos, Métodos e Abstração.
 * D - Abstração, Encapsulamento, Herança e Polimorfismo.
 * 
 **/

// declaração da variável
string resposta = "";

// repetição que se encerra quando é digitado a resposta correta
while (resposta !="D")
{
    // limpar o console, imprime a mensagem na tela, lê o valor digitado e salva na variável
    Console.Clear();
    Console.Write("Os quatro pilares do paradigma de Orientação a Objetos são:\n" +
                  "[A] - Sequenciamento, Procedimentos, Bibliotecas e Herança.\n" +
                  "[B] - Herança, Polimorfismo, Classes e Objetos.\n" +
                  "[C] - Classes, Atributos, Métodos e Abstração.\n" +
                  "[D] - Abstração, Encapsulamento, Herança e Polimorfismo.\n" +
                  "Opção: ");
    resposta = Console.ReadLine().ToUpper();
    Console.WriteLine();

    // uma seleção com as respostas
    switch (resposta)
    {
        case "A":
            Console.WriteLine("Resposta errada.\n");
            break;
        case "B":
            Console.WriteLine("Resposta errada.\n");
            break;
        case "C":
            Console.WriteLine("Resposta errada.\n");
            break;
        case "D":
            Console.WriteLine("Parábens, você acertou a resposta. Os 4 pilares da Programação Orientada a Objetos são: A Abstração, o encapsulamento, a herança e o polimorfismo.\n");
            break;
        default:
            Console.WriteLine("Resposta inválida, digite outro valor.\n");
            break;
    }

    // imprime na tela a mensagem e espera o pressionamento de alguma tecla
    Console.WriteLine("Pressione uma tecla para continuar.");
    Console.ReadKey();
}
