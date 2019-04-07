using System;

namespace TicTacoToe
{
    public static class InputManager
    {
        public static string PromptInput(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();

            return input;
        }
    }
}
