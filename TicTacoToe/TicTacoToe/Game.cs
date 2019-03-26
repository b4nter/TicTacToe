namespace TicTacoToe
{
    using System;

    internal class Game
    {
        /* private string[] thirdLine = { " ", " ", " " };
        public string[] ThirdLine { get => thirdLine; set => thirdLine = value; }
        below can be written shorter to the same as above, do not need to add variable*/
        private string playerOneSymbol;

        private string playerTwoSymbol;

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

        //    GameLogic gl = new GameLogic();
        public void PlayerMove(int x, int y, string symbol)
        {
            if (x == 1 && FirstLine[y - 1] == " ")
            {
                FirstLine[y - 1] = symbol;
            }
            else if (x == 2 && FirstLine[y - 1] == " ")
            {
                SecondLine[y - 1] = symbol;
            }
            else if (x == 3 && FirstLine[y - 1] == " ")
            {
                ThirdLine[y - 1] = symbol;
            }
        }

        public void StartGame()
        {
            Print();
            int x;
            int y;

            PlayersPick();
            while (true)
            {
                Console.Write(playerOneSymbol + " turn, choose line from 1-3: ");
                x = Int32.Parse(Console.ReadLine());
                Console.Write(playerOneSymbol + " choose column from 1-3: ");
                y = Int32.Parse(Console.ReadLine());
                PlayerMove(x, y, playerOneSymbol);
                Print();
            }
        }

        public void PlayersPick()
        {
            Console.Write("Player one choose 'x' or 'o' as your symbol: ");
            playerOneSymbol = Console.ReadLine();
            while (true)
            {
                if (playerOneSymbol == "x")
                {
                    Console.WriteLine("Player two you are left with 'o'");
                    break;
                }
                else if (playerOneSymbol == "o")
                {
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
    }
}
