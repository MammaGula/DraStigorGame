using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraStigorGame.Game
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(string userId) : base(userId) { }

        public override int TakePins(Board board)
        {
            return 0;
        }
    }
}
