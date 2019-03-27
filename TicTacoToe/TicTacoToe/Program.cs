namespace TicTacoToe
{
    using System;

    internal class Program
    {
        internal static Game game = new Game();

        internal static void Main(string[] args)
        {
            
            WinRules wr = new WinRules(game);
            

            Console.ReadLine();
        }

        static void Turn(string symbol)
        {
            Console.WriteLine(symbol + " turn, choose row and column from 1 to 3");
            int x = ChooseLine();
            int y = ChooseColumn();
            if (game.PlaceSymbolAt(x, y, symbol))
            {
                game.Print();
            }
            else
            {
                Console.WriteLine("You can not place " + symbol + " at" + x + ", " + y);
            }
        }

        internal static int ChooseLine()
        {
            int x;
            while (true)
            {
                Console.Write("Row: ");
                string row = Console.ReadLine();

                if (!Int32.TryParse(row, out x) || x < 1 || x > 3)
                {
                    Console.WriteLine("Please choose from 1 to 3");
                }
                else { return x; }
            }
        }

        internal static int ChooseColumn()
        {
            while (true)
            {
                int y;
                Console.Write("Column: ");
                string column = Console.ReadLine();

                if (!Int32.TryParse(column, out y) || y < 1 || y > 3)
                {
                    Console.WriteLine("Please choose from 1 to 3");
                }
                else { return y; }
            }
        }
    }
}
