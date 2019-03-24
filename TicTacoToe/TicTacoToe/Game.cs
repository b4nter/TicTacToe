using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacoToe
{
    class Game
    {
        // private string[] First { get; set; } => {" "," ", " ", }
        //  private string[] FirstLine 
        private string[] firstLine = { " ", " ", " " };
        private string[] secondLine = { " ", " ", " " };
        private string[] thirdLine = { " ", " ", " " };

        public string[] FirstLine{ get => firstLine; set => firstLine = value; }
        public string[] SecondLine { get => secondLine; set => secondLine = value; }
        public string[] ThirdLine { get => thirdLine; set => thirdLine = value; }

        public void Print()
        {
            Console.WriteLine("    1   2   3");
            Console.WriteLine("  |---|---|---|");
            Console.WriteLine("1 | " + FirstLine[0] + " | " + FirstLine[1] + " | " + FirstLine[2] + " |");
            Console.WriteLine("  |---|---|---|");
            Console.WriteLine("1 | " + SecondLine[0] + " | " + SecondLine[1] + " | " + SecondLine[2] + " |");
            Console.WriteLine("  |---|---|---|");
            Console.WriteLine("1 | " + ThirdLine[0] + " | " + ThirdLine[1] + " | " + ThirdLine[2] + " |");
            Console.WriteLine("  |---|---|---|");
        }
        //    GameLogic gl = new GameLogic();

    }
}
