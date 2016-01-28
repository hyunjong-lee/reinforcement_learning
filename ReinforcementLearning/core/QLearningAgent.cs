using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    public class QLearningAgent
    {
        private double _epsilon;
        private double _gamma;
        private double _alpha;
        private int _numberOfTraining;

        public QLearningAgent()
        {
        }

        double getQValue(GameState state, Action action)
        {
            return 0.0;
        }

        double computeValueFromQValues(GameState state)
        {
            return 0.0;
        }

        Action computeActionFromQValues(GameState state)
        {
            return Action.STOP;
        }

        Action getAction(GameState state)
        {
            return Action.STOP;
        }

        void update(GameState state, Action action, GameState nextState, double reward)
        {
        }

        Action getPolicy(GameState state)
        {
            return Action.STOP;
        }

        double getValue(GameState state)
        {
            return 0.0;
        }
    }
}
