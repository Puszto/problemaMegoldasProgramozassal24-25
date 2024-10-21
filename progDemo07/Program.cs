namespace progDemo07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1
            //Mole mole = new Mole();

            //mole.Hide(0, 10);

            //int tipp = 0;

            //do
            //{
            //    Console.Write("Kérem adja meg a vakont pozícióját: ");
            //    tipp = int.Parse(Console.ReadLine());

            //    if (tipp == mole.vakondPozicio)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine("SIKER");
            //        Console.WriteLine("A vakond pozíciója: ");
            //        mole.TurnUp();
            //        Console.ResetColor();
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Nem sikerült. Próbáld meg ismét.");
            //        Console.ResetColor();
            //    }
            //}
            //while (tipp != mole.vakondPozicio);


            ////2
            //GroundControl groundControl = new GroundControl();
            //Flight flight1 = new Flight("LH1337", "Zurich", new DateTime(2024, 10, 20, 11, 10, 0), 0);
            //Flight flight2 = new Flight("W62221", "Madagascar", new DateTime(2024, 10, 20, 11, 50, 0), 0);
            //Flight flight3 = new Flight("FR3586", "Berlin", new DateTime(2024, 10, 20, 16, 05, 0), 0);
            //groundControl.AddFlight(flight1);
            //groundControl.AddFlight(flight2);
            //groundControl.AddFlight(flight3);
            //groundControl.DisplayFlightData();

            //Console.WriteLine();

            //GroundControl groundControl2 = new GroundControl();
            //Flight flight4 = new Flight("LH1337", "London", new DateTime(2024, 10, 20, 11, 40, 0), 30);
            //Flight flight5 = new Flight("W62221", "Budapest", new DateTime(2024, 10, 20, 11, 40, 0), 30);
            //flight5.Cancel();
            //Flight flight6 = new Flight("FR3586", "Moscow", new DateTime(2024, 10, 20, 16, 05, 0), 0);
            //groundControl2.AddFlight(flight4);
            //groundControl2.AddFlight(flight5);
            //groundControl2.AddFlight(flight6);
            //groundControl2.DisplayFlightData();

            ////3
            //Console.Write("Kérem adjon meg egy méretet: ");
            //int meret = int.Parse(Console.ReadLine());

            //ExamResult[] examResults = new ExamResult[meret];

            //int i = 0;
            //while (i < examResults.Length)
            //{
            //    Console.Write("Random értékekkel szeretné feltölteni az adathalmazt (y/n)? - ");
            //    string yesOrNo = Console.ReadKey().KeyChar.ToString().ToLower();
            //    Console.WriteLine();
            //    if (yesOrNo == "y" || yesOrNo == "n")
            //    {
            //        if (yesOrNo == "y")
            //        {
            //            examResults[i] = new ExamResult();
            //        }

            //        else
            //        {
            //            Console.Write("Kérlek add meg a Neptun kódot: ");
            //            string neptunKodParameter = Console.ReadLine();
            //            Console.Write("Kérlek add meg a ZH pontszámot: ");
            //            int zhPontParameter = int.Parse(Console.ReadLine());

            //            examResults[i] = new ExamResult(neptunKodParameter, zhPontParameter);
            //        }

            //        i++;
            //    }

            //    else
            //    {
            //        Console.WriteLine("HIBÁS BILLENTYŰT NYOMOTT LE - Nyomjon 'y' vagy 'n' gombot.");
            //    }
            //}

            //double averageZhPont = 0;
            //Console.WriteLine($"Dolgozat eredmények: ");
            //foreach (ExamResult exams in examResults)
            //{
            //    if (exams.Passed)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine($"\t--> Neptun kód: {exams.NeptunKod} - Pontszám: {exams.ZhPontszam}");
            //    }

            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine($"\t--> Neptun kód: {exams.NeptunKod} - Pontszám: {exams.ZhPontszam}");
            //    }

            //    averageZhPont += exams.ZhPontszam;

            //}

            //Console.ResetColor();

            //Console.WriteLine($"Átlagos pontszám: {averageZhPont / examResults.Length}");

        }
    }
}