using core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinforcementLearning
{
    public class GameStateRender
    {
        private static List<Tuple<Image, Point>> _backgroundImageList;
        private static List<Tuple<Image, Point>> _heroImageList;

        static GameStateRender()
        {
            _backgroundImageList = new List<Tuple<Image, Point>>();

            var imageBlock = Image.FromFile(@"resource/landscape_block.png");
            var imageWay = Image.FromFile(@"resource/landscape_way.png");
            var imageTBody = Image.FromFile(@"resource/tower_body.png");
            var imageTUp = Image.FromFile(@"resource/tower_up.png");
            var imageHealer = Image.FromFile(@"resource/Healer.png");
            var imageBoy = Image.FromFile(@"resource/boy.png");
            var imagePrincess = Image.FromFile(@"resource/Princess.png");

            _backgroundImageList.Add(Tuple.Create(imageBlock, new Point(66 * 5, 33 * 0 + 45)));
            _backgroundImageList.Add(Tuple.Create(imageBlock, new Point(66 * 4, 33 * 1 + 45)));
            _backgroundImageList.Add(Tuple.Create(imageWay, new Point(66 * 3, 33 * 2 + 45)));
            _backgroundImageList.Add(Tuple.Create(imageWay, new Point(66 * 2, 33 * 3 + 45)));
            _backgroundImageList.Add(Tuple.Create(imageWay, new Point(66 * 1, 33 * 4 + 45)));
            _backgroundImageList.Add(Tuple.Create(imageBlock, new Point(66 * 0, 33 * 5 + 45)));
            _backgroundImageList.Add(Tuple.Create(imagePrincess, new Point(66 * 5 + 12, 33 * 0 - 99 + 45 + 10)));
            _backgroundImageList.Add(Tuple.Create(imageTBody, new Point(66 * 4 + 22, 33 * 1 + 30)));
            _backgroundImageList.Add(Tuple.Create(imageTUp, new Point(66 * 4 + 22 + 5, 33 * 1)));
            _backgroundImageList.Add(Tuple.Create(imageHealer, new Point(66 * 0 + 12, 33 * 5 - 99 + 45)));

            _heroImageList = new List<Tuple<Image, Point>>();
            _heroImageList.Add(Tuple.Create(imageBoy, new Point(66 * 1 + 12, 33 * 4 - 99 + 45)));
            _heroImageList.Add(Tuple.Create(imageBoy, new Point(66 * 2 + 12, 33 * 3 - 99 + 45)));
            _heroImageList.Add(Tuple.Create(imageBoy, new Point(66 * 3 + 12, 33 * 2 - 99 + 45)));
        }

        public static void render(Graphics g, GameState state, int x, int y)
        {
            renderBackground(g, state, x, y);
            renderHero(g, state, x, y);
            renderHp(g, state, x, y);
        }

        public static void renderBackground(Graphics g, GameState state, int x, int y)
        {
            foreach (var elem in _backgroundImageList)
            {
                g.DrawImage(elem.Item1, x + elem.Item2.X, y + elem.Item2.Y);
            }
       }

        public static void renderHero(Graphics g, GameState state, int x, int y)
        {
             g.DrawImage(_heroImageList[state.UserPos].Item1,
                x + _heroImageList[state.UserPos].Item2.X,
                y + _heroImageList[state.UserPos].Item2.Y);
        }

        public static void renderHp(Graphics g, GameState state, int x, int y)
        {
            var brush = new SolidBrush(Color.FromArgb(180, Color.DarkRed));

            // user HP
            var heroPos = _heroImageList[state.UserPos].Item2;
            g.FillRectangle(brush, heroPos.X + x + 25, heroPos.Y + y + 40, state.UserHp * 10, 10);
            g.DrawRectangle(Pens.LightGreen, heroPos.X + x + 25, heroPos.Y + y + 40, 50, 10);

            // tower HP
            g.FillRectangle(brush, x + 66 * 4 + 40, y + 33 * 1 - 15, state.TowerHp * 5, 10);
            g.DrawRectangle(Pens.LightGreen, x + 66 * 4 + 40, y + 33 * 1 - 15, 50, 10);
        }
    }
}
