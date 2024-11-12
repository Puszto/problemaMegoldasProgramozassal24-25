using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progDemo09
{
    public class Position
    {
        private int x;
        private int y;
        public int X
        {

            get 
            { 
                return x; 
            } 
            set
            {
            x = value; 
            }

        }

        public int Y
        {

            get
            {
                return y;
            }
            set
            {
                y = value;
            }

        }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Position Add(Position p_1, Position p_2)
        {
            return new Position(p_1.X + p_2.X, p_1.Y + p_2.Y);
        }

        public static Double Distance(Position p_1, Position p_2)
        {
            return Math.Sqrt(Math.Pow((p_2.X - p_1.X), 2) + Math.Pow((p_2.Y - p_1.Y), 2));
        }


    }
}
