using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progDemo07
{
    public class Mole
    {
        Random rnd = new Random();
        private int _vakondPozicio;
        public int vakondPozicio
        {
            get { return _vakondPozicio; }
        }

        //ez már nem a feladat része, ez csak extra
        private int _first;
        private int _last;
        //

        public void TurnUp()
        {
            int left = Console.GetCursorPosition().Left;
            int top = Console.GetCursorPosition().Top;
            for (int i = _first; i < _last; i++)
            {
                Console.SetCursorPosition(left+i,top);

                if (i == _vakondPozicio)
                {
                    Console.Write("M");
                }

                else
                {
                    Console.Write("_");
                }
            }
        }

        public void Hide(int first, int last)
        {
            Console.Clear();
            _vakondPozicio = rnd.Next(first, last);
            _first = first;
            _last = last;
        }

    }
}
