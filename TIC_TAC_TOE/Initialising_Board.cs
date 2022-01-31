using System;
using System.Collections.Generic;
using System.Text;

namespace TIC_TAC_TOE
{
    class Initialising_Board
    {
        public char[] Board()
        {
            char[] CreateBoard = new char[10];
            for (int i = 1; i < CreateBoard.Length; i++)
            {
                CreateBoard[i] = ' ';
            }
            Console.WriteLine("Board Initialized");
            return CreateBoard;
        }
    }
}

