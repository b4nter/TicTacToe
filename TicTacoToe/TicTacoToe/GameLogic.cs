namespace TicTacoToe
{
    internal class GameLogic
    {


        public bool IsItWinner(string[] first, string[] second, string[] third)
        {
            if (LineWin(first))
            {
                return true;
            }
            if (LineWin(second))
            {
                return true;
            }
            if (LineWin(third))
            {
                return true;
            }

            if (ColumnWin(first, second, third))
            {
                return true;
            }
            if (DiameterWin(first, second, third))
            {
                return true;
            }
            return false;
        }

        public bool LineWin(string[] list)
        {
            for (int i = 0; i < 3; i++)
            {
                if (list[i] != "x")
                {
                    return false;
                }
            }
            return true;
        }

        public bool ColumnWin(string[] first, string[] second, string[] third)
        {
            for (int i = 0; i < 3; i++)
            {
                if (first[i] == "x" && second[i] == "x" && third[i] == "x")
                {
                    return true;
                }
            }
            return false;
        }

        public bool DiameterWin(string[] first, string[] second, string[] third)
        {
            if (first[0] == "x" && second[1] == "x" && third[2] == "x")
            {
                return true;
            }
            if (first[2] == "x" && second[1] == "x" && third[0] == "x")
            {
                return true;
            }
            return false;
        }
    }
}
