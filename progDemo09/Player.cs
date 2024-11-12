using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progDemo09
{
    public class Player
    {

        public Position Position { get; set; }
        public ConsoleSprite Sprite { get; private set; }
        double kitoltesTenyezo;

        public double FillingRatio
        {
            get
            {
                return kitoltesTenyezo; 
            }

            set
            {
                kitoltesTenyezo = value;
            }

        }

        public Player(int x, int y)
        {
            Position = new Position(x, y);
            Sprite = new ConsoleSprite(ConsoleColor.Black, ConsoleColor.Green, 'O');
            FillingRatio = 0.5;
        }
    }
}