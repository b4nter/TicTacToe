namespace TicTacoToe
{
    internal class WinRules
    {
        private Game game;
        public WinRules(Game game) { this.game = game; }

        //need to improve draw
        public bool Draw()
        {
            //checks if each line is empty (" ") and returns relevant condition
            if (LineFull(game.FirstLine) && LineFull(game.SecondLine) && LineFull(game.ThirdLine))
            {
                return true;
            }
            else { return false; }
        }

        public bool LineFull(string[] line)
        {
            bool draw = false;
            for (int i = 0; i < 3; i++)
            {
                if (line[i] != " ")
                {
                    draw = true;
                }
                else { return false; }
            }
            return draw;
        }

        //checks all 8 possible win combinations
        public bool IsWinner(string symbol)
        {
            if (LineWin(this.game.FirstLine, symbol))
            {
                return true;
            }
            if (LineWin(this.game.SecondLine, symbol))
            {
                return true;
            }
            if (LineWin(this.game.ThirdLine, symbol))
            {
                return true;
            }

            if (ColumnWin(symbol))
            {
                return true;
            }
            if (DiameterWin(symbol))
            {
                return true;
            }
            return false;
        }

        //if given symbol win by line returns true
        public bool LineWin(string[] list, string symbol)
        {
            for (int i = 0; i < 3; i++)
            {
                if (list[i] != symbol)
                {
                    return false;
                }
            }
            return true;
        }

        //if given symbol wins by column returns true
        public bool ColumnWin(string symbol)
        {
            for (int i = 0; i < 3; i++)
            {
                //checks each lines 1st,2nd and 3rd columns
                if (this.game.FirstLine[i] == symbol && this.game.SecondLine[i] == symbol && this.game.ThirdLine[i] == symbol)
                {
                    return true;
                }
            }
            return false;
        }

        public bool DiameterWin(string symbol)
        {
            if (this.game.FirstLine[0] == symbol && this.game.SecondLine[1] == symbol && this.game.ThirdLine[2] == symbol)
            {
                return true;
            }
            if (this.game.FirstLine[2] == symbol && this.game.SecondLine[1] == symbol && this.game.ThirdLine[0] == symbol)
            {
                return true;
            }
            return false;
        }
    }
}
