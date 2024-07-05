using tabuleiro;

namespace xadrez
{
    internal class Torre(Tabuleiro tab, Cor cor) : Peca(tab, cor)
    {
        public override string ToString()
        {
            return "T";
        }
    }
}
