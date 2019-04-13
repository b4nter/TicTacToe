using System.Linq;

namespace TicTacoToe
{
    internal class WinCondition
    {
        private const int NumberOfSymbolsPerLine = 3;

        private char[] _firstRow;
        private char[] _secondRow;
        private char[] _thirdRow;

        public void AddGameState(Game game)
        {
            _firstRow = game.FirstRow;
            _secondRow = game.SecondRow;
            _thirdRow = game.ThirdRow;
        }

        public bool IsWinner(char symbol)
        {
            return
                AreMatchingSymbols(_firstRow, symbol)
                || AreMatchingSymbols(_secondRow, symbol)
                || AreMatchingSymbols(_thirdRow, symbol)
                || IsColumnWin(symbol)
                || (IsDiagonalWin(symbol));
        }

        public bool IsDraw()
        {
            var areAllLinesEmpty = IsRowFull(_firstRow) && IsRowFull(_secondRow) && IsRowFull(_thirdRow);
            return areAllLinesEmpty;
        }

        public bool IsRowFull(char[] row)
        {
            return !row.Any(c => c == ' ');
        }

        public bool AreMatchingSymbols(char[] list, char symbol)
        {
             return list.All(c => c == symbol);
        }

        public bool IsColumnWin(char symbol)
        {
            for (var i = 0; i < NumberOfSymbolsPerLine; i++)
            {
                var topLeftToBottomRight = new[] {_firstRow[i], _secondRow[i], _thirdRow[i]};
                if (AreMatchingSymbols(topLeftToBottomRight, symbol))
                {
                    return true;
                }
            }

            return false;
        }
        
        public bool IsDiagonalWin(char symbol)
        {
            var topLeftToBottomRight = new[] {_firstRow[0], _secondRow[1], _thirdRow[2]};
            var isTopLeftToBottomRightWon = AreMatchingSymbols(topLeftToBottomRight, symbol);

            var bottomLeftToTopRight = new[] { _firstRow[2], _secondRow[1], _thirdRow[0]};
            var isBottomLeftToTopRight = AreMatchingSymbols(bottomLeftToTopRight, symbol);

            return isTopLeftToBottomRightWon || isBottomLeftToTopRight;
        }
    }
}
