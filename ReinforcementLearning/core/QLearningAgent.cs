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

        public static readonly double ACTION_MIN_VALUE = -987654321.0;

        public double epsilon { get; set; }
        public double gamma { get; set; }
        public double alpha { get; set; }

        private Random _rand;

        public QLearningAgent()
        {
            _stateQValueMap = new Dictionary<Tuple<GameState, Action>, double>();
            _rand = new Random(DateTime.Now.Millisecond);
        }

        public void registerStateQValue(GameState state, Action action, double qValue)
        {
            _stateQValueMap[Tuple.Create(state, action)] = qValue;
        }

        public double getQValue(GameState state, Action action)
        {
            return _stateQValueMap[Tuple.Create(state, action)];
        }

        public double computeValueFromQValues(GameState state)
        {
            Action action = Action.NONE;
            var value = Double.MinValue;

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

        public Action computeActionFromQValues(GameState state)
        {
            Action action = Action.NONE;
            var value = Double.MinValue;

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

        public Action getAction(GameState state)
        {
            var availActions = state.GetActionSet();
            var flipCoin = _rand.NextDouble();
            if (flipCoin < epsilon)
            {
                var selected = _rand.Next(availActions.Count());
                return availActions.ToList()[selected];
            }
            else
            {
                return computeActionFromQValues(state);
            }
        }

        public void update(GameState state, Action action, GameState nextState, double reward)
        {
            var qValue = 
                (1 - alpha) * getQValue(state, action) +
                alpha * (reward + gamma * computeValueFromQValues(nextState));

            _stateQValueMap[Tuple.Create(state, action)] = qValue;
        }

        public Action getPolicy(GameState state)
        {
            return computeActionFromQValues(state);
        }

        public double getValue(GameState state)
        {
            return computeValueFromQValues(state);
        }
    }
}
