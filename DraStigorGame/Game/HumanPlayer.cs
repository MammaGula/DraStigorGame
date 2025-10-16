using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DraStigorGame.Game
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string userId) : base(userId) { }

        public override int TakePins(Board board)
        {
            int taken; // valid amount of taken pins

            while (true)
            {
                Console.Write($"Enter amout of pins you want to take (1 or 2): ");
                string amountPin = Console.ReadLine();

                if (int.TryParse(amountPin, out taken) && (taken == 1 || taken == 2))
                {
                    if (board.TakePins(taken))
                        return taken;
                }

                Console.WriteLine("Invalid number, Try again!");
            }
        }
    }

}

