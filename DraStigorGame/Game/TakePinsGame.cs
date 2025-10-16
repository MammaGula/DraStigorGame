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
            Board board = new Board(10);
            //Console.WriteLine(board.TakePins(3));


            HumanPlayer human = new HumanPlayer("Gula");
            human.TakePins(board); 

            ComputerPlayer computer = new ComputerPlayer("CompPlayer");
            computer.TakePins(board);
        }
    }
}
