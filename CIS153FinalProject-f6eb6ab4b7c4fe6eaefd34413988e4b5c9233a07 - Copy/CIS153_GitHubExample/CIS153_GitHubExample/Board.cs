using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_GitHubExample
{
    class Board
    {
        private const int numRows = 6;
        private const int numCols = 7;
        Cell[,] gameBoard = new Cell[numRows, numCols];
    
        public int getNumRows()
        {
            return numRows;
        }
        public int getNumCols()
        {
            return numCols;
        }
        public Cell getCell(int r, int c)
        {
            return gameBoard[r, c];
        }

        public Cell[,] getGameBoard()
        {
            return gameBoard;
        }

        public void setGameBoardCell(Cell cell)
        {
            gameBoard[cell.getRow(), cell.getCol()] = cell;
        }

    }
}
