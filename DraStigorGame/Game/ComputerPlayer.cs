using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DraStigorGame.Game
{
    public class ComputerPlayer : Player
    {
        private Random random = new Random(); 

        public ComputerPlayer(string userId) : base(userId) { }

        public override int TakePins(Board board) 
        {
            int compRandomPins = random.Next(1, 3);

            board.TakePins(compRandomPins);

            Console.WriteLine($"💻 Computer Player tar {compRandomPins} stickor.");
            return compRandomPins;
        }
    }
}
