using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    public class Environment
    {
        public static GameState GetNextState(GameState s, Action a)
        {
            var nextS = s.Clone();

            if (a == core.Action.LEFT)
                nextS = new GameState(nextS.UserHp, nextS.UserPos - 1, nextS.TowerHp);
            else if (a == core.Action.RIGHT)
                nextS = new GameState(nextS.UserHp, nextS.UserPos + 1, nextS.TowerHp);

            if (nextS.UserPos == 0)
                nextS = new GameState(5, nextS.UserPos, nextS.TowerHp);
            else if (nextS.UserPos == 2)
                nextS = new GameState(nextS.UserHp - 1, nextS.UserPos, nextS.TowerHp - 1);

            return nextS;
        }

        public static double GetReward(GameState s, Action a)
        {
            var nextS = GetNextState(s, a);
            
            var reward = -10.0;
            if (nextS.UserHp == 0)
                reward -= 100000;
            else if (nextS.TowerHp == 0)
                reward = 100000;

            reward += (s.TowerHp - nextS.TowerHp) * 5;
            reward += nextS.UserHp - s.UserHp;

            return reward;
        }
    }
}
