using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            try
            {
                PartidaXadrez partida = new PartidaXadrez();


                Tela.imprimirTabuleiro(partida.tab);
                Console.ReadLine();
            }
            catch (TabuleiroExcepition ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}