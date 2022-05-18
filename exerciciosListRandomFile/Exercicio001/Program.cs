// See https://aka.ms/new-console-template for more information

/* 
 * 1) Fazer um programa em VS que gere uma lista com n valores randômicos e inteiros para glicemia (entre 45 a 500). 
 * O progrma deve calcular média, valor mínimo, valor máximo e mediana.
 * Sugere-se criar um menu como:
 * 
 * MENU
 * 1 - Gerar lista
 * 2 - Exibir lista
 * 3 - Mostrar medidas centrais (média, valores min e max e mediana)
 * 4 - Sair
 * Opção: ____
 * 
 * Observação, toda vez que a opção 1 for acionada, o usuário deve definir quantos números serão gerados na lista
 **/

/// <summary>
/// declaração das variáveis e listas
/// </summary>
List <int> listaGlicemia = new List<int> ();
string opcao = "";

/// <summary>
/// repetição do programa para abrir o menu e receber a opçaõ do usuário
/// </summary>
do
{
    // imprime o menu na tela
    Console.Clear();
    Console.WriteLine("===================================MENU===================================\n" +
                       "[1] - Gerar Lista.\n" +
                       "[2] - Exibir Lista.\n" +
                       "[3] - Mostrar medidas centrais (média, valores min e max e mediana.\n" +
                       "[4] - Sair.\n" +
                       "==========================================================================");
    Console.Write("Opção: ");
    opcao = Console.ReadLine ();
    Console.WriteLine();

    // lê a opção e seleciona conforme o digitado
    switch (opcao) 
    { 
        case "1":
            // gerar lista aleatória
            Console.Write("Digite a quantidade de elementos da lista: ");
            int quantidadeNumeros = int.Parse (Console.ReadLine ());
            Console.WriteLine();

            Random rand = new Random ();

            for (int i = 0; i < quantidadeNumeros; i++)
            {
                listaGlicemia.Add (rand.Next(45, 500));
            }
            break;
        case "2":
            // exibir lista gerada
            Console.WriteLine("Exibindo lista gerada: ");
            if (listaGlicemia.Count == 0)
            {
                Console.WriteLine("A lista ainda não foi gerada.");
            }
            else
            {
                // maneira 1
                for (int i = 0; i < listaGlicemia.Count; i++)
                {
                    Console.WriteLine(listaGlicemia[i]);
                }

                // maneira 2
                //foreach (int i in listaGlicemia)
                //{
                //    Console.WriteLine(i);
                //}

                Console.WriteLine();
            }
            break;   
        case "3":
            // mostrar as medidas centrais
            if (listaGlicemia.Count == 0)
            {
                Console.WriteLine("A lista ainda não foi gerada.");
            }
            else
            {
                float media;
                int min;
                int max;
                int soma;
                float mediana;
                List<int> listaTMP = new List<int>();

                listaTMP.AddRange(listaGlicemia);
                listaTMP.Sort();
                min = listaTMP[0];
                max = listaTMP[listaTMP.Count - 1];
                soma = 0;

                foreach (int i in listaTMP)
                {
                    soma += i;
                }

                media = soma / listaTMP.Count;

                int meio = listaTMP.Count / 2;
                if (listaTMP.Count % 2 != 0)
                {
                    mediana = listaTMP[meio];
                }
                else
                {
                    mediana = listaTMP[meio] + listaTMP[meio - 1] / 2;
                }

                Console.WriteLine("================================RESULTADOS=================================\n" +
                                  "A média da lista é:                                     {0:F2}\n" +
                                  "O valor mínino da lista é:                              {1:F2}\n" +
                                  "O valor máximo da lisá é :                              {2:F2}\n" +
                                  "A mediana é da lista é:                                 {3:F2}\n" +
                                   "==========================================================================\n", media, min, max, mediana);
            }
            break;
        case "4":
            // sair do programa
            Console.WriteLine("Obrigado por usar o sistema. Saindo...\n");
            break;
        default:
            // para outros valores
            Console.WriteLine("Opção inválida, digite um número válido.\n");
            break;
    }

    // imprime na tela a mensagem e espera o input do teclado
    Console.WriteLine("Digite algo para continuar!");
    Console.ReadKey();

} while (opcao != "4");
