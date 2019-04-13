namespace TicTacoToe
{
    using System;

    internal class Game
    {
        private WinCondition _winCondition;

        public Game(WinCondition winCondition)
        {
            _winCondition = winCondition;
            _winCondition.AddGameState(this);
        }

        public void StartGame()
        {
            PrintBoard();
            var players = CreatePlayers();
            Play(players);
        }

        private char[] CreatePlayers()
        {
            const char cross = 'x';
            const char circle = 'o';
            char[] players = { cross, circle };

            return players;
        }

        private void Play(char[] players)
        {
            while (true)
            {
                foreach (var player in players)
                {
                    TakeTurn(player);
                    if (_winCondition.IsWinner(player))
                    {
                        PrintWinner(player);
                        break;
                    }

                    if (_winCondition.IsDraw())
                    {
                        PrintDraw();
                        break;
                    }
                }
            }
        }

        private void PrintBoard()
        {
            Console.WriteLine("    1   2   3");
            Console.WriteLine("  |---|---|---|");

            RenderRow(1, FirstRow[0], FirstRow[1], FirstRow[2]);
            RenderRow(2, SecondRow[0], SecondRow[1], SecondRow[2]);
            RenderRow(3, ThirdRow[0], ThirdRow[1], ThirdRow[2]);
        }

        private void RenderRow(int rowNumber, params char[] symbols)
        {
            Console.WriteLine($"{rowNumber} | {symbols[0]} | {symbols[1]} | {symbols[2]} |");
            Console.WriteLine("  |---|---|---|");
        }

        public void TakeTurn(char symbol)
        {
            Console.WriteLine($"{symbol} turn, choose row and column from 1 to 3");

            var column = ChooseLine(false);
            var row = ChooseLine(true);
            if (PlaceSymbolAt(column, row, symbol))
            {
                PrintBoard();
            }
            else
            {
                Console.WriteLine($"You can not place '{symbol}' at {column}, {row}");
                TakeTurn(symbol);
            }
        }

        public int ChooseLine(bool isRow)
        {
            var prompt = isRow ? "Row" : "Column";
            var isValidChoice = false;
            while (!isValidChoice)
            {
                var input = InputManager.PromptInput($"{prompt}: ");

                isValidChoice = !int.TryParse(input, out var choice) || choice < 1 || choice > 3;
                
                if (isValidChoice)
                {
                    Console.WriteLine("Please choose from 1 to 3");
                    ChooseLine(isRow);
                }
                else
                {
                    isValidChoice = true;
                }
            }

            return 0;
        }

        public bool PlaceSymbolAt(int row, int column, char symbol)
        {
            var rows = new char[3][]
            {
                FirstRow, SecondRow, ThirdRow
            };
            return PlaceSymbol(rows[row], column, symbol);
        }

        private bool PlaceSymbol(char[] chars, int column, char symbol)
        {
            if (chars[column] != ' ') return false;
            chars[column] = symbol;
            return true;
        }

        private void PrintWinner(char symbol)
        {
            Console.WriteLine($"'{symbol}' won the game!!");
        }

        private void PrintDraw()
        {
            Console.WriteLine("It's a draw!");
        }

        // TODO: Jagged array
        public char[] FirstRow { get; set; } = { ' ', ' ', ' ' };

        public char[] SecondRow { get; set; } = { ' ', ' ', ' ' };

        public char[] ThirdRow { get; set; } = { ' ', ' ', ' ' };
    }
}
