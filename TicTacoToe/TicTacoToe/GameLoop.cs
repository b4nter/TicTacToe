using System;

namespace TicTacoToe
{
    internal class GameLoop
    {
        public void Run()
        {
            do
            {
                StartNewGame();
            } while (IsRetryRequested());
        }

        private void StartNewGame()
        {
            var game = new Game(new WinCondition());
            game.StartGame();
        }

        private bool IsRetryRequested()
        {
            Console.Write("Play again? y/n: ");
            var answer = Console.ReadLine().ToLower();
            var isRetryAccepted = answer == "y";

            return isRetryAccepted;
        }
    }
}
