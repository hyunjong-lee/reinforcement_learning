using core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReinforcementLearning
{
    public partial class ReinforcementLearning : Form
    {
        private GameState _state;

        public ReinforcementLearning()
        {
            _state = new GameState(5, 1, 5);

            InitializeComponent();
        }

        private void ReinforcementLearning_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            // initialize
            QLearningAgent agent = new QLearningAgent();
            agent.alpha = 0.2;
            agent.gamma = 0.8;
            agent.epsilon = 0.05;

            // regiser state-qvalue
            foreach (var userHp in Enumerable.Range(0, 6))
                foreach (var userPos in Enumerable.Range(0, 3))
                    foreach (var towerHp in Enumerable.Range(0, 11))
                    {
                        var state = new GameState(userHp, userPos, towerHp);

                        foreach (var action in state.GetActionSet())
                        {
                            agent.registerStateQValue(state, action, 0);
                        }
                    }

            //// learning process ...
            //foreach (var episode in Enumerable.Range(1, 20))
            //{
            //    Console.WriteLine("Episode: " + episode);
            //    processEpisode(agent);
            //    Console.WriteLine();
            //}
        }

        private void processEpisode(QLearningAgent agent)
        {
            var s = new GameState(5, 1, 10);

            var stepCount = 0;
            var totalReward = 0.0;
            while (s.UserHp > 0 && s.TowerHp > 0)
            {
                core.Action a = agent.getAction(s);
                var nextS = s.Clone();

                if (a == core.Action.LEFT)
                    nextS = new GameState(nextS.UserHp, nextS.UserPos - 1, nextS.TowerHp);
                else if (a == core.Action.RIGHT)
                    nextS = new GameState(nextS.UserHp, nextS.UserPos + 1, nextS.TowerHp);

                // time delay penalty
                var reward = -1.0;

                if (nextS.UserPos == 2)
                {
                    nextS = new GameState(nextS.UserHp - 1, nextS.UserPos, nextS.TowerHp - 1);
                    reward += 10;
                }

                if (nextS.UserHp == 0)
                    reward -= 100000;
                else if (nextS.TowerHp == 0)
                    reward = 100000;

                if (nextS.UserPos == 0)
                {
                    reward += (5 - nextS.UserHp);
                    nextS = new GameState(5, nextS.UserPos, nextS.TowerHp);
                }

                totalReward += reward;
                agent.update(s, a, nextS, reward);
                s = nextS;

                Console.WriteLine("State: {0}, Action: {1}, Reward: {2}", s, a, reward);

                Thread.Sleep(100);
                stepCount++;
            }

            Console.WriteLine("STEPS: " + stepCount);
            Console.WriteLine("TOTAL REWARD: " + totalReward);
        }

        private void learningTimer_Tick(object sender, EventArgs e)
        {
            var dPos = 1;
            if (_state.UserPos == 2) dPos = -1;
            _state = new GameState(_state.UserHp, _state.UserPos + dPos, _state.TowerHp);

            var currentContext = BufferedGraphicsManager.Current;
            var buffer = currentContext.Allocate(labelRenderingArea.CreateGraphics(), labelRenderingArea.DisplayRectangle);

            buffer.Graphics.Clear(Color.LightSteelBlue);
            //GameStateRender.renderBackground(buffer.Graphics, _state, 20, 20);
            //GameStateRender.renderBackground(buffer.Graphics, _state, 150, 150);
            //GameStateRender.renderBackground(buffer.Graphics, _state, 250, 250);
            //GameStateRender.renderBackground(buffer.Graphics, _state, 350, 350);

            //GameStateRender.renderHero(buffer.Graphics, _state, 20, 20);
            //GameStateRender.renderHero(buffer.Graphics, _state, 150, 150);
            //GameStateRender.renderHero(buffer.Graphics, _state, 250, 250);
            //GameStateRender.renderHero(buffer.Graphics, _state, 350, 350);

            //GameStateRender.renderHp(buffer.Graphics, _state, 20, 20);
            //GameStateRender.renderHp(buffer.Graphics, _state, 150, 150);
            //GameStateRender.renderHp(buffer.Graphics, _state, 250, 250);
            //GameStateRender.renderHp(buffer.Graphics, _state, 350, 350);

            GameStateRender.render(buffer.Graphics, _state, 20, 20);
            GameStateRender.render(buffer.Graphics, _state, 150, 150);
            GameStateRender.render(buffer.Graphics, _state, 250, 250);
            GameStateRender.render(buffer.Graphics, _state, 350, 350);

            buffer.Render(labelRenderingArea.CreateGraphics());
            buffer.Dispose();
        }

    }
}
