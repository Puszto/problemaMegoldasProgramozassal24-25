using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progDemo08
{
    public class Game
    {

        private Field field;
        private Buffalo[] bolenyek;

        bool IsOver
        {
            get
            {
                int count = 0;
                for (int i = 0; i < bolenyek.Length; i++)
                {
                    if (bolenyek[i].X == field.TargetX && bolenyek[i].Y == field.TargetY-1)
                    {
                        return true;
                    }

                    if (!bolenyek[i].allapot)
                    {
                        count++;
                    }
                }

                return count == bolenyek.Length;
            }
        }

        public Game(int bolenyekSzama, int jatekter)
        {
            bolenyek = new Buffalo[bolenyekSzama];
            field = new Field(jatekter);

            for (int i = 0; i < bolenyek.Length; i++)
            {
                bolenyek[i] = new Buffalo();
            }
        }

        private void VisualizeElements()
        {
            Console.Clear();
            field.Show();
            foreach (var item in bolenyek)
            {
                item.Move(field);
                item.Show();
            }
        }

        private void Shoot()
        {
            Console.SetCursorPosition(0, 10);
            int x;
            int y;

            do
            {
                Console.Write("Kérem adjon meg egy X pozíciót: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Kérem adjon meg egy Y pozíciót: ");
                y = int.Parse(Console.ReadLine()) - 1;

                if (!field.AllowedPosition(x,y))
                {
                    Console.WriteLine("Hibás koordinátákat adott meg, kérem adja meg őket újra.");
                }

            }

            while (!field.AllowedPosition(x, y));

            for (int i = 0; i < bolenyek.Length; i++)
            {
                if (bolenyek[i].X == x && bolenyek[i].Y == y)
                {
                    bolenyek[i].Deactivate();
                }
            }
        }

        public void Run()
        {
            while (!IsOver)
            {
                Console.WriteLine("\n\n");
                VisualizeElements();

                if (IsOver)
                {
                    break;
                }

                Shoot();
            }
            Console.Clear();

            for (int i = 0; i < bolenyek.Length; ++i)
            {
                if (bolenyek[i].allapot)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vesztettél, bölények eljutottak a célig.");
                    Console.ResetColor();
                    return;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nyertél, eltaláltad a bölényeket.");
            Console.ResetColor();
        }
    }
}