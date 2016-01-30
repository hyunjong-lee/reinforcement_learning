using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    public class GameState
    {
        public int UserHp { get; }
        public int UserPos { get; }
        public int TowerHp { get; }

        public static readonly int USER_POS_MIN = 0;
        public static readonly int USER_POS_MAX = 2;

        public GameState(int userHp, int userPos, int towerHp)
        {
            UserHp = userHp;
            UserPos = userPos;
            TowerHp = towerHp;
        }

        public IEnumerable<Action> GetActionSet()
        {
            yield return Action.STOP;
            if (UserPos > USER_POS_MIN) yield return Action.LEFT;
            if (UserPos < USER_POS_MAX) yield return Action.RIGHT;
        }

        public GameState Clone()
        {
            return new GameState(UserHp, UserPos, TowerHp);
        }

        public override bool Equals(object obj)
        {
            if (obj is GameState)
            {
                var s = (GameState)obj;
                return
                    UserHp == s.UserHp &&
                    UserPos == s.UserPos &&
                    TowerHp == s.TowerHp;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return UserHp * 10000 + UserPos * 100 + TowerHp;
        }

        public override string ToString()
        {
            return string.Format("UserHP: {0}, UserPos: {1}, TowerHP: {2}", UserHp, UserPos, TowerHp);
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
