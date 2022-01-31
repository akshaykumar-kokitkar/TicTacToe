using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

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

            for (int index = 1; index < board.Length; index++)
            {
                board[index] = ' ';
            }
            return board;
        }

        public char[] UserSymbol()
        {
            char[] userSymbol = new char[2];


            while (true)
            {
                Console.WriteLine("Choose a Letter X or O : ");

                char userInput = Convert.ToChar(Console.ReadLine());
                if (userInput == 'X')
                {
                    userSymbol[0] = 'X';
                    userSymbol[1] = 'O';
                    return userSymbol;
                }
                else if (userInput == 'O')
                {
                    userSymbol[0] = 'O';
                    userSymbol[1] = 'X';
                    return userSymbol;
                }
                else Console.WriteLine("Invalid Input");
            }
        }
    }
}
