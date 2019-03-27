namespace TicTacoToe
{
    using System;

    internal class Program
    {
        

        internal static void Main(string[] args)
        {


            Game game = new Game();
            
            game.StartGame();
            while (true)
            {
                Console.Write("Play again? y/n: ");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    game = new Game();
                    game.StartGame();
                }
                else { break; }
            }
            
        }

        
    }
}
