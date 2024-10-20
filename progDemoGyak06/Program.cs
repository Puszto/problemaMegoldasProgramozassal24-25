using System.Globalization;

namespace progDemoGyak06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////1
            //Book book1 = new Book("J. K. Rowling", "Harry Potter and the Philosopher's Stone", 1997, 223);
            //Book book2 = new Book("J. K. Rowling", "Harry Potter and the Chamber of Secrets", 1998, 251);
            //Book book3 = new Book("J. K. Rowling", "Harry Potter and the Prisoner of Azkaban", 1999, 317);

            //Console.WriteLine(book3.AllData());
            //Console.WriteLine();

            ////Mindezt megcsinálhatjuk egy tömbben is. Book típusú tömböt hozunk létre, melyben minden egyes
            ////adott indexú elem egy Book objektumot fog tárolni, melyre meghívható az AllData() metódus.

            //Console.WriteLine("A 'konyvek' tömbünk tartalma: ");
            //Book[] konyvek = new Book[3];
            //konyvek[0] = book1;
            //konyvek[1] = book2;
            //konyvek[2] = book3;

            //foreach (Book item in konyvek)
            //{
            //    Console.WriteLine(item.AllData());
            //}

            ////Különféle műveleteket és végezhetünk így az eltárolt adatok segítségével, pl.: összegezhetjük
            ////az oldalszámokat

            //int oldalakSzamaSum = 0;
            //foreach (Book item in konyvek)
            //{
            //    oldalakSzamaSum += item.GetPages();
            //}

            //Console.WriteLine($"Az eltárolt ({konyvek.Length}) könyvek oldalainak összege: {oldalakSzamaSum}");


            ////2

            //Teglalap teglalap1 = new Teglalap(12, 8, System.ConsoleColor.Red);
            //teglalap1.Draw(5, 10);

            //Teglalap teglalap2 = new Teglalap(3, 10, System.ConsoleColor.Green);
            //teglalap2.Draw(1, 5);

            //Teglalap teglalap3 = new Teglalap(5, 20, System.ConsoleColor.Magenta);
            //teglalap3.Draw(8, 15);


            ////3

            //Runner futo1 = new Runner("Leonard Galvan", 1, 8);

            //Runner futo2 = new Runner("Brayan Fuller", 4, 10);

            //Console.Write("Kérem adja meg az elérni kívánt távolságot: ");
            //int bemenetDistance = int.Parse(Console.ReadLine());


            //while (futo1.GetDistance() < bemenetDistance)
            //{
            //    Console.Clear();
            //    futo1.RefreshDistance(1);
            //    futo2.RefreshDistance(1);

            //    futo1.Show();
            //    futo2.Show();

            //    Thread.Sleep(1000);
            //}

            


            ////4

            //Titkosit Caesar = new Titkosit(5);
            //string eredeti = "Alea iacta est - A kocka el van vetve";
            //string titkositott = Caesar.Encode(eredeti);
            //string visszaEredeti = Caesar.Decode(titkositott);

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"Eredeti: {eredeti}");

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine($"Titkosított: {titkositott}");

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"Visszaalakított: {visszaEredeti}");

            //Console.ResetColor();


            //    //5
            //    StreamReader reader = new StreamReader("NHANES_1999-2018.csv");
            //    reader.ReadLine();

            //    //1
            //    double summaBMIFerfi = 0;
            //    double countBMIFerfi = 0;

            //    double summaBMINoi = 0;
            //    double countBMINoi = 0;

            //    //2
            //    double countLargerThenFiveSixNo = 0;

            //    //3
            //    double maxBMI = 0;
            //    double maxBMIVercukor = 0;

            //    //4
            //    double harmincasBmiEletkor = 0;
            //    double countHarmincasBmiEletkor = 0;

            //    string line = "";
            //    while((line = reader.ReadLine()) != null)
            //    {
            //        string[]tmpAdatok = line.Split(',');
            //        NHANES tarolo = new NHANES
            //            (
            //                int.Parse(tmpAdatok[0]),
            //                tmpAdatok[1],
            //                double.Parse(tmpAdatok[2], CultureInfo.InvariantCulture),
            //                double.Parse(tmpAdatok[3], CultureInfo.InvariantCulture),
            //                double.Parse(tmpAdatok[4], CultureInfo.InvariantCulture),
            //                double.Parse(tmpAdatok[5], CultureInfo.InvariantCulture)
            //            );

            //        //1
            //        if (tarolo._RIAGENDR == 1.0)
            //        {
            //            summaBMIFerfi += tarolo._BMXBMI;
            //            countBMIFerfi++;
            //        }

            //        if (tarolo._RIAGENDR == 2.0)
            //        {
            //            summaBMINoi += tarolo._BMXBMI;
            //            countBMINoi++;
            //        }

            //        //2
            //        if (tarolo._LBDGLUSI > 5.6)
            //        {
            //            countLargerThenFiveSixNo++;
            //        }

            //        //3
            //        if (tarolo._BMXBMI > maxBMI)
            //        {
            //            maxBMI = tarolo._BMXBMI;
            //            maxBMIVercukor = tarolo._LBDGLUSI;
            //        }

            //        //4
            //        if (tarolo._BMXBMI >= 30)
            //        {
            //            harmincasBmiEletkor += tarolo._RIDAGEYR;
            //            countHarmincasBmiEletkor++;
            //        }
            //    }

            //    reader.Close();

            //    Console.WriteLine($"1. feladat\n" +
            //        $"Testtömegindex férfi: {summaBMIFerfi / countBMIFerfi}\n" +
            //        $"Testtömegindex női: {summaBMINoi / countBMINoi}");

            //    Console.WriteLine($"2. feladat\n" +
            //        $"Nők kiknek vércukorszinte nagyobb mint 5.6: " +
            //        $"{countLargerThenFiveSixNo / countBMINoi * 100}");

            //    Console.WriteLine($"3. feladat\n" +
            //        $"Max BMI-vel rendelkező személy adatai: \n" +
            //        $"BMI szintje: {maxBMI}\n" +
            //        $"Vércukorszintje: {maxBMIVercukor}");

            //    Console.WriteLine($"4. feladat\n" +
            //        $"Legalább 30-as BMI értékkel rendelkező személyek átlagos életkora: " +
            //        $"{harmincasBmiEletkor / countHarmincasBmiEletkor}");

        }
    }
}