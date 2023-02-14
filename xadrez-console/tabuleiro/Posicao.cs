using System;

namespace tabuleiro
{
    public class Posicao
    {
        public int linhas { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.linhas = linha;
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return linhas
                + ", "
                + coluna;
        }
    }
}