using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacoToe
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            WinRules gw = new WinRules(game);
            // Console.WriteLine(gw.IsWinner("x"));

            game.StartGame();
            /*game.Print();
            game.PlayerMove(1, 2, "x");
            game.Print();
            game.PlayerMove(2, 2, "x");
            game.Print();*/
           // game.Print();
            Console.ReadLine();
        }
    }
}
