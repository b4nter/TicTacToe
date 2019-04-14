namespace TicTacoToe
{
    using System;

    internal class Program
    {
        internal static void Main(string[] args)
        {
            var gameLoop = new GameLoop();
           // gameLoop.Run();

            WinCondition wc = new WinCondition();
            Game game = new Game(wc);
            wc.AddGameState(game);

            Console.WriteLine(game.ChooseLine(true));
           

            //Console.WriteLine(TestInt());

            




            Console.ReadLine();
        }

        public static int TestInt()
        {

            Console.Write("Entry: ");
            var entry = Console.ReadLine();
            int.TryParse(entry, out int number);
            return number;
        }
    }

    
    
}
