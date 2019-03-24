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

            game.Print();
            game.FirstLine[1] = "x";
            game.Print();
            Console.ReadLine();
        }
    }
}
