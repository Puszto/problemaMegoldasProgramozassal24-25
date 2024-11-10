using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progDemo08
{
    public class Buffalo
    {
        private Random rnd = new Random();
        private int x;
        private int y;
        public bool allapot { get; private set; }

        public Buffalo()
        {
            x = 1;
            y = 0;
            allapot = true;
        }

        public int X
        {
            get
            {
                return x;
            }
            private set
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

            private set
            {
                y = value;
            }
        }

        public void Move(Field field)
        {
            if (allapot)
            {
                int localX;
                int localY;
                int lepes;

                do
                {
                    localX = x;
                    localY = y;
                    lepes = rnd.Next(3);

                    if (lepes == 0)
                    {
                        localX += 1;
                        localY += 1;
                    }

                    if (lepes == 1)
                    {
                        localX += 1;
                    }

                    if (lepes == 2)
                    {
                        localY += 1;
                    }

                } while (!field.AllowedPosition(localX, localY));

                if (field.AllowedPosition(localX, localY))
                {
                    X = localX;
                    Y = localY;
                }
            }
        }

        public void Deactivate()
        {
            allapot = false;
        }

        public void Show()
        {
            Console.SetCursorPosition(x, y);
            if (allapot)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write("B");
            Console.ResetColor();
        }
    }
}