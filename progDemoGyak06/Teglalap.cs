using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progDemoGyak06
{
    public class Teglalap
    {
        double _szelesseg;
        double _magassag;
        System.ConsoleColor _color;

        public Teglalap(double szelesseg, double magassag, System.ConsoleColor color)
        {
            _szelesseg = szelesseg;
            _magassag = magassag;
            _color = color;
        }

        private double Area()
        {
            return _szelesseg * _magassag;
        }

        private bool IsValid()
        {
            return Area() > 0;
        }

        public void Draw(int x, int y)
        {
            Console.ForegroundColor = _color;
            for (int i = 0; i < _szelesseg; i++)
            {
                for (int j = 0; j < _magassag; j++)
                {
                    Console.SetCursorPosition(x + i, y + j);
                    Console.Write("-");
                }
            }
            Console.ResetColor();
        }
    }
}
