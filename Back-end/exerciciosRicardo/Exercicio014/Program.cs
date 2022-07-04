// See https://aka.ms/new-console-template for more information

/*
 * Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
 * link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
 * do arquivo usando este link (em minutos).
 **/

// declaração das variavéis
double tamanhoDownload, velocidadeDownload, tempoDownload, minutos, segundos;

// imprime a mensagem na tela, lê o valor digitado pelo usuário e salva na variável
Console.Write("Digite o tamanho do arquivo que será baixo (em MB): ");
tamanhoDownload = double.Parse(Console.ReadLine());
Console.Write("Digite a velocidade da internet (em Mbps): ");
velocidadeDownload = double.Parse(Console.ReadLine());

// 1 MB aproximadamente 8 Mb ------> tempoDownload (em s) = (tamanhoDownload  * 8)/velocidadeDownload

// efetua a conta para definir o tempo de download 
tempoDownload = (double) (tamanhoDownload * 8) / velocidadeDownload;

// converte uma parte inteira para minutos
minutos = (int) tempoDownload / 60;

// o resto da divisão inteira é adiciona aos segundos restantes da conta
segundos = (int) tempoDownload % 60;

// imprime o resultado do tempo na tela
Console.WriteLine("O tempo de download será de {0:00} minutos e {1:00} segundos.", minutos, segundos);