using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    public class GameState
    {
        public int UserHp { get; set; }
        public int UserPos { get; set; }
        public int TowerHp { get; set; }
    }

    public enum Action
    {
        WEST,
        EAST,
        STOP,
    }
}
