using System;

namespace TIC_TAC_TOE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Tic Tac Toe Game");

            //char[] CreateBoard;
            //Initialising_Board obj = new Initialising_Board();
            //CreateBoard = obj.Board();

            //UC2
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            char[] CreateBoard;
            Initialising_Board obj = new Initialising_Board();
            CreateBoard = obj.Board();
            obj.ChoosePlayer();
        }
    }
}
