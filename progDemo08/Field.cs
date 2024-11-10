using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progDemo08
{
    public class Field
    {
        private int M { get; }

        public int TargetX
        {
            get
            {
                return M;
            }
        }
        public int TargetY { get
            {
                return M;
            }
        }
        public Field(int m)
        {
            M = m;
        }

        public bool AllowedPosition(int x, int y)
        {
            return x <= TargetX && x >= 0 && y < TargetY && y >= 0;
        }

        public void Show()
        {
            for (int i = 0; i < TargetX; i++)
            {
                for (int j = 0; j <= TargetX+1; j++)
                {
                    if (j == 0 || j == TargetX+1)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}