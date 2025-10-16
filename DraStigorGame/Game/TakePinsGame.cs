using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("┃                                    ┃");
            Console.WriteLine("┃      Welcome to TakePins Game      ┃");
            Console.WriteLine("┃                                    ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to TakePins Game");
            Console.WriteLine("- Two players take turns taking pins.\n" +
                "- One can take one or two pins.\n " +
                "- The one who takes the last pin wins. ");

            Console.WriteLine("Let's go...\n");
            Console.ResetColor();


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
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n******{current.UserId} won the game!🏆******");
                    Console.ResetColor();

                    break;
                }

                // Switch players
                current = (current == human) ? computer : human;
              
            }

            Console.WriteLine("The game is over. Thank you for playing!\n");
            Console.WriteLine("----------------------------------------");
        }
    }
}
