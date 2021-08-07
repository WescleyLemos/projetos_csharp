using tabuleiro;

namespace xadrez_console
{
    internal class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    var impressao = tab.peca(i, j) == null ? "- " : tab.peca(i, j) + " ";
                    System.Console.Write(impressao);
                }
                System.Console.WriteLine();
            }
        }
    }
}