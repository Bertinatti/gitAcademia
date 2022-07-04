// See https://aka.ms/new-console-template for more information

/* 
 * 4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
 * Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
 * Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
 * Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
 * escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
 * de votos em branco.
 **/

// declaração das variáveis
int votosJoao, votosZeca, votosBrancos, votosNulos;
string opcVoto, sair;

// atribuição de valor zero as variáveis de contagem e vazio para a variável condicional do while
votosJoao = 0;
votosZeca = 0;
votosBrancos = 0;
votosNulos = 0;
sair = "";

// efetua o laço de repetição enquanto a resposta não for FIM
do
{
    // menu para a votação
    Console.WriteLine("==========================================\n" +
                      "                  VOTAÇÃO                 \n" +
                      "==========================================\n" +
                      "Em quem será o seu voto para Prefeito?\n" +
                      "\n- João." +
                      "\n- Zeca." +
                      "\n- Branco." +
                      "\nDemais opções serão consideradas nulas.\n" +
                      "==========================================");
    opcVoto = Console.ReadLine().ToUpper();
    Console.Clear();

    // condicional para verificar em quem foi o voto ou se o usuário quer efetuar a saída
    if(opcVoto == "JOÃO" || opcVoto == "JOAO")
    {
        votosJoao++;
    }
    else if(opcVoto == "ZECA")
    {
        votosZeca++;
    }
    else if(opcVoto=="BRANCO" || opcVoto == "BRANCOS")
    {
        votosBrancos++;
    }
    else if(opcVoto == "FIM")
    {
        sair = "FIM";
    }
    else
    {
        votosNulos++;
    }

} while (sair != "FIM");

// menu de exibição da contagem dos votos
Console.WriteLine("==========================================\n" +
                  "            CONTAGEM DE VOTOS             \n" +
                  "==========================================\n" +
                  "[1] - João:             {0} votos.\n" +
                  "[2] - Zeca:             {1} votos.\n" +
                  "[3] - Brancos:          {2} votos.\n" +
                  "[4] - Nulos:            {3} votos.\n" +
                  "==========================================", votosJoao, votosZeca, votosBrancos, votosNulos);
