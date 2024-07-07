using tabuleiro;
using xadrez;
using xadrez_console;

try
{
    PartidaDeXadrez partida = new();

    while (!partida.Terminada)
    {
        Console.Clear();
        Tela.ImprimirTabuleiro(partida.Tab);

        Console.WriteLine();
        Console.Write("Origem: ");
        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
        Console.Write("Destino: ");
        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

        partida.ExecutaMovimento(origem, destino);
    }
} catch (TabuleiroException e) {
    Console.WriteLine(e.Message);
}