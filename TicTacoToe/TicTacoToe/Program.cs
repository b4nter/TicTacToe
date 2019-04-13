namespace TicTacoToe
{
    using System;

    internal class Program
    {
        internal static void Main(string[] args)
        {
            var gameLoop = new GameLoop();
            gameLoop.Run();

            WinCondition wc = new WinCondition();
            Game game = new Game(wc);
            wc.AddGameState(game);

            Console.WriteLine(wc.IsWinner('o'));


            Console.ReadLine();
        }
    }
}
