using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace progDemo09
{
    public enum ItemType
    {
        Ammo,
        BFGCell,
        Door,
        LevelExit,
        Medikit,
        ToxicWaste,
        Wall
    }
    public class GameItem
    {
        private static bool isPlaying = false;
        private static SoundPlayer soundPlayer;
        private static Stopwatch stopwatch = new Stopwatch();
        public Position Position { get; private set; }
        ConsoleSprite ConsoleSprite;

        public ConsoleSprite Sprite
        {
            get
            {
                return ConsoleSprite;
            }

            set
            {
                ConsoleSprite = value;
            }
        }
        public ItemType ItemType { get; private set; }

        double kitoltesTenyezo;
        public double FillingRatio
        {
            get { return kitoltesTenyezo; }
            set { kitoltesTenyezo = value; }
        }

        bool elerhetoseg;
        public bool Available
        {
            get { return elerhetoseg; }
            set { elerhetoseg = value; }
        }

        private void SetInitialProperties()
        {
            if (ItemType == ItemType.Ammo)
            {
                ConsoleSprite = new ConsoleSprite(ConsoleColor.Red, ConsoleColor.Yellow, 'A');
                FillingRatio = 0.0;
                Available = true;
            }

            if (ItemType == ItemType.BFGCell)
            {
                ConsoleSprite = new ConsoleSprite(ConsoleColor.Green, ConsoleColor.White, 'B');
                FillingRatio = 0.0;
                Available = true;
            }

            if (ItemType == ItemType.Door)
            {
                ConsoleSprite = new ConsoleSprite(ConsoleColor.DarkGray, ConsoleColor.Yellow, '/');
                FillingRatio = 1.0;
                Available = true;
            }

            if (ItemType == ItemType.LevelExit)
            {
                ConsoleSprite = new ConsoleSprite(ConsoleColor.Cyan, ConsoleColor.Black, 'E');
                FillingRatio = 1.0;
                Available = true;
            }

            if (ItemType == ItemType.Medikit)
            {
                ConsoleSprite = new ConsoleSprite(ConsoleColor.Gray, ConsoleColor.Red, '+');
                FillingRatio = 0.0;
                Available = true;
            }

            if (ItemType == ItemType.ToxicWaste)
            {
                ConsoleSprite = new ConsoleSprite(ConsoleColor.Green, ConsoleColor.White, ':');
                FillingRatio = 0.0;
                Available = true;
            }

            if (ItemType == ItemType.Wall)
            {
                ConsoleSprite = new ConsoleSprite(ConsoleColor.Gray, ConsoleColor.Gray, ' ');
                FillingRatio = 1.0;
                Available = true;
            }
        }

        public GameItem(int x, int y, ItemType itemType)
        {
            Position = new Position(x, y);
            ItemType = itemType;
            SetInitialProperties();
        }

        public static async Task soundEffectAsync(string path, ItemType itemType)
        {
            if (ItemType.Door == itemType)
            {
                if (!isPlaying)
                {
                    isPlaying = true;
                    soundPlayer = new SoundPlayer(Path.Combine("sounds/", path));
                    soundPlayer.Play();

                    stopwatch.Restart();

                    await Task.Delay(1500);

                    var elapsed = stopwatch.ElapsedMilliseconds;

                    if (elapsed >= 1500)
                    {
                        isPlaying = false;
                        stopwatch.Stop();
                    }
                }
            }

            else
            {
                soundPlayer = new SoundPlayer(Path.Combine("sounds/", path));
                soundPlayer.Play();
            }
        }

        public void Interact()
        {
            if (ItemType == ItemType.Ammo || ItemType == ItemType.BFGCell || ItemType == ItemType.Medikit)
            {
                if (Available)
                {
                    Available = false;
                }
            }

            if (ItemType == ItemType.Door)
            {
                if (Available)
                {
                    ConsoleSprite = new ConsoleSprite(ConsoleColor.DarkGray, ConsoleColor.DarkMagenta, '/');
                    FillingRatio = 0.0;
                    Available = false;
                }

                else if (!Available)
                {
                    ConsoleSprite = new ConsoleSprite(ConsoleColor.DarkGray, ConsoleColor.Yellow, '/');
                    FillingRatio = 1.0;
                    Available = true;
                }
            }
        }
    }
}
