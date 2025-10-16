using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraStigorGame.Game
{
    public abstract class Player
    {
        public string UserId { get; private set; }

        protected Player(string userId)
        {
            UserId = userId;
        }

        public string GetUserId()
        {
            return UserId;
        }

        public abstract int TakePins(Board board); 
    }
}
