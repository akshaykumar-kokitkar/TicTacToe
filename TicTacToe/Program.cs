using System;

namespace TicTacToe
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe");

            Board board = new Board();
            board.UserSymbol();
        }
    }
}