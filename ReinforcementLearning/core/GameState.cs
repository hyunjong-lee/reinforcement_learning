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

        public static readonly int USER_POS_MIN = 0;
        public static readonly int USER_POS_MAX = 2;

        public IEnumerable<Action> GetActionSet()
        {
            yield return Action.STOP;
            if (UserPos > USER_POS_MIN) yield return Action.LEFT;
            if (UserPos < USER_POS_MAX) yield return Action.RIGHT;
        }
    }

    public enum Action
    {
        LEFT,
        RIGHT,
        STOP,
        NONE,
    }
}
