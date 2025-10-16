using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraStigorGame.Game
{
    public class Board
    {

        private int pinsLeft;  // Number of pins left on the board

        public Board(int startPins)
        {
            pinsLeft = startPins;
        }

        public bool TakePins(int pickedPins)  // Take 1 or 2 pins
        {        
            if ((pickedPins >= 1 && pickedPins < 3) && (pickedPins <= pinsLeft))
            {
                pinsLeft -= pickedPins;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetPinsLeft() // Number of pins left on the board
        {
            return pinsLeft;
        }

        public bool IsGameOver() // If the game is over 
        {
            return pinsLeft == 0;
        }


    }
}
