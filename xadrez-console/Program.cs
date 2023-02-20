using tabuleiro;
using xadrez_console;
using xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.terminada)
    {
        Console.Clear();
        Tela.ImprimirTabuleiro(partida.tab);

        Console.WriteLine();
        Console.Write("Digite a origem da peça: ");
        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
        Console.Write("Digite o destino da peça: ");
        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

        partida.ExecutaMovimento(origem, destino);
    }

}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}