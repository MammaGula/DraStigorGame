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
            int humanPins; // valid amount of taken pins

            while (true)
            {
                Console.Write($"Enter amout of pins you want to take (1 or 2): ");
                string inputPin = Console.ReadLine();

                if (int.TryParse(inputPin, out humanPins) && (humanPins == 1 || humanPins == 2))
                {
                    if (board.TakePins(humanPins))
                        Console.WriteLine($"👤 {UserId} tar {humanPins} stickor.");
                    
                    return humanPins;
                }

                Console.WriteLine("\nInvalid number, Try again⚠️\n");
            }

            //while (true)
            //{
            //    Console.Write($"Enter amount of pins you want to take (1 or 2): ");
            //    string inputPin = Console.ReadLine();

            //    if (!int.TryParse(inputPin, out humanPins) || (humanPins != 1 && humanPins != 2))
            //    {
            //        Console.WriteLine("\nInvalid number, Try again⚠️\n");
            //        continue;
            //    }

            //   
            //    if (!board.TakePins(humanPins))
            //    {
            //        Console.WriteLine($"\nCannot take {humanPins} stickor now. Pins left: {board.GetPinsLeft()}\n");
            //        continue;
            //    }

            //    Console.WriteLine($"👤 {UserId} tar {humanPins} stickor.");
            //    return humanPins;
            //}




        }
    }

}

