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
            string x = "x";
            Console.WriteLine("    1   2   3");
            Console.WriteLine("  |---|---|---|");
            Console.WriteLine("1 | " + x + " | " + x + " | "+ x + " |");
            Console.WriteLine("  |---|---|---|");
            Console.WriteLine("2 | " + x + " | " + x + " | " + x + " |");
            Console.WriteLine("  |---|---|---|");
            Console.WriteLine("3 | " + x + " | " + x + " | " + x + " |");
            Console.WriteLine("  |---|---|---|");

            Console.ReadLine();
        }
    }
}
