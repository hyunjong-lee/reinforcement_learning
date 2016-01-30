using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    public class QLearningAgent
    {
        private Dictionary<Tuple<GameState, Action>, Double> _stateQValueMap;

        private double _epsilon;
        private double _gamma;
        private double _alpha;
        private int _numberOfTraining;

        private static double ACTION_MIN_VALUE = -987654321.0;


        public QLearningAgent()
        {
        }

        double getQValue(GameState state, Action action)
        {
            return _stateQValueMap[Tuple.Create(state, action)];
        }

        double computeValueFromQValues(GameState state)
        {
            Action action = Action.NONE;
            var value = ACTION_MIN_VALUE;

            var availActions = state.GetActionSet();
            foreach (var a in availActions)
            {
                var v = _stateQValueMap[Tuple.Create(state, a)];
                if (v > value)
                {
                    action = a;
                    value = v;
                }
            }

            return value;
        }

        Action computeActionFromQValues(GameState state)
        {
            Action action = Action.NONE;
            var value = ACTION_MIN_VALUE;

            var availActions = state.GetActionSet();
            foreach (var a in availActions)
            {
                var v = _stateQValueMap[Tuple.Create(state, a)];
                if (v > value)
                {
                    action = a;
                    value = v;
                }
            }

            return action;
        }

        Action getAction(GameState state)
        {
            var availActions = state.GetActionSet();
            Random rand = new Random();
            var flipCoin = rand.NextDouble();
            if (flipCoin < _epsilon)
            {
                var selected = rand.Next(availActions.Count());
                return availActions.Skip(selected - 1).Take(1).First();
            }
            else
            {
                return computeActionFromQValues(state);
            }
        }

        void update(GameState state, Action action, GameState nextState, double reward)
        {
            var qValue = 
                (1 - _alpha) * getQValue(state, action) +
                _alpha * (reward + _epsilon * computeValueFromQValues(nextState));

            _stateQValueMap[Tuple.Create(state, action)] = qValue;
        }

        Action getPolicy(GameState state)
        {
            return computeActionFromQValues(state);
        }

        double getValue(GameState state)
        {
            return computeValueFromQValues(state);
        }
    }
}
