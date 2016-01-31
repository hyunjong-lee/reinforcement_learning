using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    public class CompactGameState : GameState
    {
        public CompactGameState(int userHp, int userPos, int towerHp)
            : base(userHp, userPos, towerHp)
        {
        }

        public override bool Equals(object obj)
        {
            if (obj is GameState)
            {
                var s = (GameState)obj;
                return
                    UserHp == s.UserHp &&
                    UserPos == s.UserPos &&
                    (TowerHp > 0) == (s.TowerHp > 0);
            }
            return false;
        }


        public override int GetHashCode()
        {
            return UserHp * 10000 + UserPos * 100 + (TowerHp > 0 ? 1 : 0);
        }
    }

}
