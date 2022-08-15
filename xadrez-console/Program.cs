using Tabuleiro;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _tabuleiro tab = new _tabuleiro(8, 8);

            Console.WriteLine(tab.Linhas + " - " + tab.Colunas);
        }
    }
}