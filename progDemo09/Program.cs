namespace progDemo09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();


            //PÁLYA ELKÉSZÍTÉSE FALAKKAL
            game.Items.Add(new GameItem(1, 0, ItemType.Wall));
            for (int i = 1; i < 5; i++)
            {
                game.Items.Add(new GameItem(i, 0, ItemType.Wall));
            }

            for (int i = 0; i < 4; i++)
            {
                game.Items.Add(new GameItem(5, i, ItemType.Wall));
            }

            game.Items.Add(new GameItem(0, 2, ItemType.Wall));
            for (int i = 2; i < 6; i++)
            {
                game.Items.Add(new GameItem(1, i, ItemType.Wall));
            }

            for (int i = 1; i < 7; i++)
            {
                game.Items.Add(new GameItem(i, 5, ItemType.Wall));
            }

            for (int i = 6; i < 10; i++)
            {
                game.Items.Add(new GameItem(i, 2, ItemType.Wall));
            }

            game.Items.Add(new GameItem(9, 3, ItemType.Wall));
            game.Items.Add(new GameItem(9, 4, ItemType.Wall));
            game.Items.Add(new GameItem(9, 5, ItemType.Wall));
            game.Items.Add(new GameItem(8, 5, ItemType.Wall));

            game.Items.Add(new GameItem(6, 6, ItemType.Wall));
            game.Items.Add(new GameItem(6, 7, ItemType.Wall));
            game.Items.Add(new GameItem(6, 8, ItemType.Wall));
            game.Items.Add(new GameItem(7, 8, ItemType.Wall));
            game.Items.Add(new GameItem(8, 8, ItemType.Wall));
            game.Items.Add(new GameItem(9, 8, ItemType.Wall));
            game.Items.Add(new GameItem(10, 8, ItemType.Wall));

            game.Items.Add(new GameItem(10, 7, ItemType.Wall));
            game.Items.Add(new GameItem(10, 6, ItemType.Wall));
            game.Items.Add(new GameItem(10, 5, ItemType.Wall));
            game.Items.Add(new GameItem(9, 6, ItemType.Wall));

            //FELVEHETŐ TÁRGYAK ELHELYEZÉSE
            game.Items.Add(new GameItem(4, 1, ItemType.Ammo));
            game.Items.Add(new GameItem(4, 2, ItemType.Ammo));

            game.Items.Add(new GameItem(2, 3, ItemType.BFGCell));

            game.Items.Add(new GameItem(2, 4, ItemType.Medikit));


            //AJTÓK ELHELYEZÉSE
            game.Items.Add(new GameItem(1, 1, ItemType.Door));
            game.Items.Add(new GameItem(5, 4, ItemType.Door));
            game.Items.Add(new GameItem(7, 5, ItemType.Door));
            game.Items.Add(new GameItem(9, 7, ItemType.LevelExit));

            //JÁTÉK INDÍTÁSA
            game.Run();
        }
    }
}
