namespace TicTacoToe
{
    using System;

    internal class Game
    {
        private string playerOneSymbol;

        private string playerTwoSymbol;

        public void StartGame()
        {
            WinRules wr = new WinRules(this);
            SymbolPicks();
            while (true)
            {
                PlayerTurn(playerOneSymbol);
                Print();
                if (wr.IsWinner(playerOneSymbol))
                {
                    Console.WriteLine(playerOneSymbol + " is winner!");
                    break;
                } else if(wr.Draw())
                {
                    break;
                }


                PlayerTurn(playerTwoSymbol);
                Print();
                if (wr.IsWinner(playerTwoSymbol))
                {
                    Console.WriteLine(playerTwoSymbol + " is winner!");
                    break;
                }
            }
        }

        public void PlayerTurn(string symbol)
        {
            int x;
            int y;
            Console.Write(symbol + " turn, choose line and column from 1 to 3: \n");
            while (true)
            {
                Console.Write("Line: ");
                string line = Console.ReadLine();
                if (!Int32.TryParse(line, out x) || x < 0 || x > 3)
                {
                    Console.WriteLine("Please choose from 1 to 3");
                }
                else { break; }
            }

            while (true)
            {
                Console.Write("Column: ");
                string column = Console.ReadLine();
                if (!Int32.TryParse(column, out y) || y < 0 || y > 3)
                {
                    Console.WriteLine("Please choose from 1 to 3");
                }
                else { break; }
            }

            PlaceSymbolAt(x, y, symbol);
        }

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
            } else { return false; }
        }

        public void SymbolPicks()
        {
            Console.Write("Player one choose 'x' or 'o' as your symbol: ");
            playerOneSymbol = Console.ReadLine();
            while (true)
            {
                if (playerOneSymbol == "x")
                {
                    playerTwoSymbol = "o";
                    Console.WriteLine("Player two you are left with 'o'");
                    break;
                }
                else if (playerOneSymbol == "o")
                {
                    playerTwoSymbol = "x";
                    Console.WriteLine("Player two you are left with 'x'");
                    break;
                }
                else
                {
                    Console.Write("Invalid character, please choose 'x' or 'o': ");
                    playerOneSymbol = Console.ReadLine();
                }
            }
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
