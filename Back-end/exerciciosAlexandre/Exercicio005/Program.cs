// See https://aka.ms/new-console-template for more information

/*
 * 5. Modifique o programa em VS anterior para aceitar votos nulos 
 * (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
 * Ao final, informe o nome do candidato vencedor, o número de votos nulos 
 * e o número de pessoas que votaram.
 **/

// declaração das variáveis
int votosJoao, votosZeca, votosBrancos, votosNulos, totVotos;
string opcVoto, sair;

// atribuição de valor zero as variáveis de contagem e vazio para a variável condicional do while
votosJoao = 0;
votosZeca = 0;
votosBrancos = 0;
votosNulos = 0;
totVotos = 0;
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
    if (opcVoto == "JOÃO" || opcVoto == "JOAO")
    {
        votosJoao++;
    }
    else if (opcVoto == "ZECA")
    {
        votosZeca++;
    }
    else if (opcVoto == "BRANCO" || opcVoto == "BRANCOS")
    {
        votosBrancos++;
    }
    else if (opcVoto == "FIM")
    {
        // tirando um dos votos da contagem, pois o FIM tbm entrará na contagem
        sair = "FIM";
        totVotos--;
    }
    else
    {
        votosNulos++;
    }

    totVotos++;

} while (sair != "FIM");

if(votosJoao > votosZeca)
{
    // menu de exibição da contagem dos votos
    Console.WriteLine("===========================================\n" +
                      "            CONTAGEM DE VOTOS              \n" +
                      "===========================================\n" +
                      "[1] - João:             {0} votos.\n" +
                      "[2] - Zeca:             {1} votos.\n" +
                      "[3] - Brancos:          {2} votos.\n" +
                      "[4] - Nulos:            {3} votos.\n" +
                      "[5] - Total de votos :  {4}.\n"+
                      "===========================================\n" +
                      "João será o próximo prefeito com {0} votos.\n" +
                      "===========================================", votosJoao, votosZeca, votosBrancos, votosNulos, totVotos);

}
else
{
    // menu de exibição da contagem dos votos
    Console.WriteLine("===========================================\n" +
                      "            CONTAGEM DE VOTOS              \n" +
                      "===========================================\n" +
                      "[1] - João:             {0} votos.\n" +
                      "[2] - Zeca:             {1} votos.\n" +
                      "[3] - Brancos:          {2} votos.\n" +
                      "[4] - Nulos:            {3} votos.\n" +
                      "[5] - Total de votos :  {4}.\n" +
                      "===========================================\n" +
                      "Zeca será o próximo prefeito com {0} votos.\n" +
                      "===========================================", votosJoao, votosZeca, votosBrancos, votosNulos, totVotos);
}
