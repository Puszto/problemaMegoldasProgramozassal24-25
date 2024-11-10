namespace progDemo08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1. feladat - FUTSAL CSAPAT
            ////---MEGOLDÁS 1
            //Team team = new Team(5);

            //Player player1 = new Player("Péter", Position.Goalkeeper);
            //Player player2 = new Player("Imre", Position.Forward);
            //Player player3 = new Player("Tamás", Position.Defender);
            //Player player4 = new Player("Ádám", Position.Winger);
            //Player player5 = new Player("Tóth", Position.Winger);
            //Player player6 = new Player("Sándor", Position.Goalkeeper);

            //// 1. Játékosok felvétele
            //Console.WriteLine("-------------------");
            //Console.WriteLine("->Első megoldás<-");
            //Console.WriteLine("1. lépés -> játékosok felvétele");
            //team.Include(player1);
            //team.Include(player2);
            //team.Include(player3);
            //team.Include(player4);
            //team.Include(player5);

            //// 2. Megnézzük, hogy megtelt-e a csapat
            //Console.WriteLine("2. lépés -> szabad helyek ellenőrzése");
            //Console.WriteLine($"\t---> Tele van a csapat? {team.IsFull}");

            //// 3. Még egy kapus hozzáadása, ami már nem jó, mivel csak 1 kapus lehet egy csapatban
            //Console.WriteLine("-------------------");
            //Console.WriteLine("3. lépés -> plussz játékos felvétele");
            //Console.WriteLine($"\t---> Elérhető: {team.IsAvailable(player6)}");
            //team.Include(player6);

            //// 4. Játékosok kiíratása
            //Console.WriteLine("-------------------");
            //Console.WriteLine("4. lépés -> játékosok kiiratása");
            //Console.WriteLine("Játékosok:");
            //foreach (Player item in team._players)
            //{
            //    Console.WriteLine($"\t---> {item.ToString()}");
            //}

            //////---MEGOLDÁS 2
            ////Megcsinálhatjuk mindezt dinamikusan is, pl.: dinamikusan vesszük föl az adatokat a csapatba
            ////1. lépés -> játékosok legenerálása metódussal, valamint játékosok felvétele
            ////a csapatba
            //Console.WriteLine("-------------------");
            //Console.WriteLine("->Második megoldás<-");
            //Team team2 = new Team(5);
            //Player[] generatedPlayers = RandomPlayers(5);
            //foreach (Player item in generatedPlayers)
            //{
            //    team2.Include(item);
            //}

            ////2. lépés -> mivel a generálásnál nem kezeljük le az esetlegesen ismétlődést, tehát
            ////nincs megszabva, hogy pl.: ha generáltunk egy 'goalkeeper'-t, akkor utána már ne
            ////generáljon ismét egy 'goalkeeper'-t, mivel a csapatba csak 1 szerepelhet benne.
            ////Tehát véletlenül előállít játékosokat, akik vagy bekerülnek a csapatba, vagy nem.
            //Console.WriteLine("");
            //foreach (Player item in team2._players)
            //{
            //    Console.WriteLine($"\t---> {item.ToString()}");
            //}


            ////2. feladat - BÖLÉNYVADÁSZ JÁTÉK
            //Game game = new Game(1,6);
            //game.Run();
        }

        public static Player[] RandomPlayers(int db)
        {
            Random rnd = new Random();
            Player[] generatedPlayers = new Player[db];
            int idx = 0;
            string[] names = new string[]
            {
                "Anna", "Bence", "Csilla", "Dávid", "Eszter", "Ferenc", "Gábor", "Hanna", "Imre", "Júlia",
                "Kata", "László", "Márk", "Noémi", "Orsolya", "Péter", "Réka", "Sándor", "Tamás", "Zoltán",
                "Balázs", "Emese", "György", "Irén", "János", "Krisztina", "Levente", "Miklós", "Nikolett",
                "Olivér", "Patrícia", "Róbert", "Szilvia", "Tibor", "Viktória", "Ádám", "Boglárka", "Csenge"
            };

            int goalkeeperCount = 0;
            int defenderCount = 0;
            int wingerCount = 0;
            int forwardCount = 0;

            while (idx < generatedPlayers.Length)
            {

                string localName = names[rnd.Next(names.Length)];
                Position localPosition = (Position)rnd.Next(0, 4);
                if (localPosition == Position.Goalkeeper && goalkeeperCount < 1)
                {
                    goalkeeperCount++;
                    generatedPlayers[idx] = new Player(localName, localPosition);
                    idx++;
                }

                if (localPosition == Position.Defender && defenderCount < 1)
                {
                    defenderCount++;
                    generatedPlayers[idx] = new Player(localName, localPosition);
                    idx++;
                }

                if (localPosition == Position.Winger && wingerCount < 2)
                {
                    wingerCount++;
                    generatedPlayers[idx] = new Player(localName, localPosition);
                    idx++;
                }

                if (localPosition == Position.Forward && forwardCount < 1)
                {
                    forwardCount++;
                    generatedPlayers[idx] = new Player(localName, localPosition);
                    idx++;
                }
            }

            return generatedPlayers;
        }
    }
}