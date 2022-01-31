using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        public Board()
        {
            char[] board = IntializedBoard();
        }
        
        public char[] IntializedBoard()
        {
            char[] board = new char[10];

            for (int index = 0; index < board.Length; index++)
            {
                board[index] = ' ';
            }
            return board;
        }
    }
}
