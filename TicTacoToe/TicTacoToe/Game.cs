namespace TicTacoToe
{
    using System;

    internal class Game
    {
        public void StartGame()
        {
            WinRules wr = new WinRules(this);
            Print();
            while (true)
            {
                
                Turn("x");
                if (wr.IsWinner("x"))
                {
                    Console.WriteLine("'x' won the game!!");
                    break;
                }

                if (wr.Draw())
                {
                    Console.WriteLine("It's a draw!");
                    break;
                }

                Turn("o");
                if (wr.IsWinner("o"))
                {
                    Console.WriteLine("'o' won the game!!");
                    break;
                }
            }
        }

        public void Turn(string symbol)
        {
            Console.WriteLine(symbol + " turn, choose row and column from 1 to 3");
            while (true)
            {
                
                int x = ChooseLine();
                int y = ChooseColumn();
                if (PlaceSymbolAt(x, y, symbol))
                {
                    Print();
                    break;
                }
                else
                {
                    Console.WriteLine("You can not place '" + symbol + "' at " + x + ", " + y);
                }
            }
        }

        //only possible line to choose is 1, 2 or 3
        public int ChooseLine()
        {
            int x;
            while (true)
            {
                Console.Write("Row: ");
                string row = Console.ReadLine();

                //if entry does not meet requirements prints error
                if (!Int32.TryParse(row, out x) || x < 1 || x > 3)
                {
                    Console.WriteLine("Please choose from 1 to 3");
                }
                else { return x; }
            }
        }

        //only possible column to choose is 1, 2 or 3
        public int ChooseColumn()
        {
            while (true)
            {
                int y;
                Console.Write("Column: ");
                string column = Console.ReadLine();
                //if entry does not meet requirements prints error
                if (!Int32.TryParse(column, out y) || y < 1 || y > 3)
                {
                    Console.WriteLine("Please choose from 1 to 3");
                }
                else { return y; }
            }
        }

        //x is line, y is column
        //places symbol at requested line and spot if its free and returns true 
        public bool PlaceSymbolAt(int x, int y, string symbol)
        {

            if (x == 1 && FirstLine[y - 1] == " ")
            {
                FirstLine[y - 1] = symbol;
                return true;
            }
            else if (x == 2 && SecondLine[y - 1] == " ")
            {
                SecondLine[y - 1] = symbol;
                return true;
            }
            else if (x == 3 && ThirdLine[y - 1] == " ")
            {
                ThirdLine[y - 1] = symbol;
                return true;
            }
            else { return false; }
        }

        public string[] FirstLine { get; set; } = { " ", " ", " " };

        public string[] SecondLine { get; set; } = { " ", " ", " " };

        public string[] ThirdLine { get; set; } = { " ", " ", " " };

        public void Print()
        {
            Console.WriteLine("    1   2   3");
            Console.WriteLine("  |---|---|---|");
            Console.WriteLine("1 | " + FirstLine[0] + " | " + FirstLine[1] + " | " + FirstLine[2] + " |");
            Console.WriteLine("  |---|---|---|");
            Console.WriteLine("2 | " + SecondLine[0] + " | " + SecondLine[1] + " | " + SecondLine[2] + " |");
            Console.WriteLine("  |---|---|---|");
            Console.WriteLine("3 | " + ThirdLine[0] + " | " + ThirdLine[1] + " | " + ThirdLine[2] + " |");
            Console.WriteLine("  |---|---|---|");
        }
    }
}
