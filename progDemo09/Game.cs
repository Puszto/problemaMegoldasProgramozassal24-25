using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace progDemo09
{
    public  class Game
    {
        Player player;

        bool aktualisAllapot;

        public bool Exited
        {
            get
            {
                return aktualisAllapot;
            }

            set
            {
                aktualisAllapot = value;
            }
        }

        public List<GameItem> Items;

        public Game()
        {
            player = new Player(0,0);
            Items = new List<GameItem>();
            Exited = false;
        }

        private void RenderSingleSprite(Position position, ConsoleSprite consoleSprite)
        {
            if (Console.WindowWidth > position.X && position.X >= 0 && Console.WindowHeight > position.Y && position.Y >= 0)
            {
                Console.SetCursorPosition(position.X, position.Y);
                Console.BackgroundColor = consoleSprite.Background;
                Console.ForegroundColor = consoleSprite.Foreground;
                Console.Write(consoleSprite.Glyph);
            }
        }

        private void RenderGame()
        {
            Console.CursorVisible = false;
            Console.Clear();
            RenderSingleSprite(player.Position, player.Sprite);
            for (int i = 0; i < Items.Count; i++)
            {
                RenderSingleSprite(Items[i].Position, Items[i].Sprite);
            }

            foreach (var item in GetGameItemsWithinDistance(player.Position, 0))
            {
                if (item.ItemType == ItemType.BFGCell || item.ItemType == ItemType.Ammo || item.ItemType == ItemType.Medikit)
                {
                    item.Interact();
                    CleanUpGameItems();
                    GameItem.soundEffectAsync("dsitemup.wav", item.ItemType);
                }

                if (item.ItemType == ItemType.ToxicWaste)
                {
                    GameItem.soundEffectAsync("dsplpain.wav", item.ItemType);
                }
            }
            Console.ResetColor();
        }

        private void CleanUpGameItems()
        {
            List<GameItem> torolt = new List<GameItem>();
            for (int i = 0; i < Items.Count; i++)
            {
                if (!Items[i].Available && Items[i].ItemType != ItemType.Door && Items[i].ItemType != ItemType.LevelExit)
                {
                    torolt.Add(Items[i]);
                }
            }

            for (int i = 0; i < torolt.Count; i++)
            {
                Items.Remove(torolt[i]);
            }
        }

        private void UserAction()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressed = Console.ReadKey(true);

                if (pressed.Key == ConsoleKey.D)
                {
                    foreach (GameItem item in GetGameItemsWithinDistance(player.Position, 1))
                    {
                        if (item.ItemType == ItemType.Door || item.ItemType == ItemType.LevelExit)
                        {
                            item.Interact();

                            if (item.ItemType == ItemType.Door)
                            {
                                if (!item.Available)
                                {
                                    GameItem.soundEffectAsync("dsdorcls.wav", item.ItemType);
                                }

                                else if (item.Available)
                                {
                                    GameItem.soundEffectAsync("dsdoropn.wav", item.ItemType);
                                }
                            }

                            if (item.ItemType == ItemType.LevelExit)
                            {
                                GameItem.soundEffectAsync("dsswtchn.wav", item.ItemType);
                                Thread.Sleep(500);
                                Exited = true;
                            }
                        }
                    }
                }

                switch (pressed.Key)
                {
                    case ConsoleKey.Escape: Exited = true; break;
                    case ConsoleKey.LeftArrow: Move(player, Position.Add(player.Position, new Position(-1, 0))); break;
                    case ConsoleKey.RightArrow: Move(player, Position.Add(player.Position, new Position(1, 0))); break;
                    case ConsoleKey.UpArrow: Move(player, Position.Add(player.Position, new Position(0, -1))); break;
                    case ConsoleKey.DownArrow: Move(player, Position.Add(player.Position, new Position(0, 1))); break;
                }
            }
        }
        private List<GameItem> GetGameItemsWithinDistance(Position position, double tavolsag)
        {
            List<GameItem> kigyujtott = new List<GameItem>();   
            for (int i = 0; i < Items.Count; i++)
            {
                if (Position.Distance(Items[i].Position, position) <= tavolsag)
                {
                    kigyujtott.Add(Items[i]);
                }
            }

            return kigyujtott;
        }

        private double GetTotalFillingRatio(Position position)
        {
            List<GameItem> kozelben = GetGameItemsWithinDistance(position, 0);

            double summa = 0;
            for (int i = 0; i < kozelben.Count; i++)
            {
                summa += kozelben[i].FillingRatio;
            }
            return summa;
        }

        private void Move(Player player, Position position)
        {
            double summa = GetTotalFillingRatio(position) + player.FillingRatio;
            if (summa <= 1.0)
            {
                player.Position = position;
            }
        }

        private void GameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---SIKERESEN TELJESÍTETTED A PÁLYÁT---");
            Console.ResetColor();
        }

        public void Run()
        {
            while(!Exited)
            {
                RenderGame();
                UserAction();
                Thread.Sleep(25);
            }

            GameOver();

        }
    }
}