using tabuleiro;

namespace xadrez
{
    internal class Rei(Tabuleiro tab, Cor cor) : Peca(tab, cor)
    {
        public override string ToString()
        {
            return "R";
        }
    }
}
