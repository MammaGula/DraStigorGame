using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraStigorGame.Game
{
    internal class TakePinsGame
    {
        public static void Main(string[] args)
        {
            //Board board = new Board(10);
            ////Console.WriteLine(board.TakePins(3));


            //HumanPlayer human = new HumanPlayer("Gula");
            //human.TakePins(board);

            //ComputerPlayer computer = new ComputerPlayer("CompPlayer");
            //computer.TakePins(board);


            Board board = new Board(10); // 
            HumanPlayer human = new HumanPlayer("Gula");
            ComputerPlayer computer = new ComputerPlayer("Computer");

            Player current = human; // human starts

            while (!board.IsGameOver()) // game loop
            {
                Console.WriteLine($"There are {board.GetPinsLeft()} pins on the table.\n");
               
                int takenPins = current.TakePins(board);

                if (board.IsGameOver())
                {
                    Console.WriteLine($"{current.UserId} won the game!\n");
                    break;
                }

                // Switch players
                current = (current == human) ? computer : human;
            }

            Console.WriteLine("The game is over. Thank you for playing!\n");
        }
    }
}
