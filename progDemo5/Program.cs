//using System.Globalization;

//////1
////string[] bemenet = File.ReadAllLines("1.feladat.txt");

////for (int i = 0; i < bemenet.Length; i++)
////{
////    string colorString = bemenet[i].Split("#")[0];
////    string coloredText = bemenet[i].Split("#")[1];

////    if (colorString.Equals("Red"))
////    {
////        Console.ForegroundColor = ConsoleColor.Red;
////        Console.WriteLine(coloredText);
////    }

////    else if (colorString.Equals("Blue"))
////    {
////        Console.ForegroundColor = ConsoleColor.Blue;
////        Console.WriteLine(coloredText);
////    }

////    else if (colorString.Equals("Green"))
////    {
////        Console.ForegroundColor = ConsoleColor.Green;
////        Console.WriteLine(coloredText);
////    }
////}

////Console.ResetColor();

//////2
////int[] kihuzottSzamok = new int[5];
////int kihuzott = 0;
////Random rnd = new Random();
////string kulcs = "";
////DateTime current = DateTime.Now;

////do
////{
////    int generalt = rnd.Next(0, 5);

////    if (kihuzott == 0)
////    {
////        kihuzottSzamok[kihuzott] = generalt;
////        kihuzott++;
////    }

////    else
////    {
////        bool helyes = true;

////        for (int i = 0; i < kihuzott && helyes; i++)
////        {
////            if (kihuzottSzamok[i] == generalt)
////            {
////                helyes = false;
////            }
////        }

////        if (helyes)
////        {
////            kihuzottSzamok[kihuzott] = generalt;
////            kihuzott++;
////        }
////    }

////    if (kihuzott == kihuzottSzamok.Length - 1)
////    {
////        Console.Write($"On {current.Year}. {current.Month}. {current.Day}. numbers were: ");
////        string kiirat = $"On {current.Year}. {current.Month}. {current.Day}. numbers were: ";
////        current = current.AddDays(7);
////        for (int i = 0; i < kihuzottSzamok.Length; i++)
////        {
////            Console.Write(kihuzottSzamok[i] + " ");
////            kiirat += $"{kihuzottSzamok[i]} ";
////        }
////        kiirat += "\n";
////        File.AppendAllText("2.feladat.txt", kiirat);
////        Console.Write("Another week? [y/n]");
////        kulcs = Console.ReadLine();

////        kihuzottSzamok = new int[5];
////        kihuzott = 0;
////    }


////} while (kulcs.ToLower() != "n");


//////3
////string[] beolvas = File.ReadAllLines("3.feladat.txt");

////string[] elsoSor = beolvas[0].Split(" ");
////int x = int.Parse(elsoSor[0]);
////int y = int.Parse(elsoSor[1]);
////int z = int.Parse(elsoSor[2]);

////Console.WriteLine($"Eredeti bemenetem: {x}, {y}, {z}");

//////0fok hangya jobbra néz
//////90fok hangya felfelé néz
//////180fok hangya balra néz
//////270fok hangya lefele néz

////for (int i = 1; i < beolvas.Length; i++)
////{
////    if (beolvas[i].Contains("go"))
////    {
////        if (z == 0)
////        {
////            x += int.Parse(beolvas[i].Split(" ")[1]);
////        }

////        if (z == 90)
////        {
////            y += int.Parse(beolvas[i].Split(" ")[1]);
////        }

////        if (z == 180)
////        {
////            x -= int.Parse(beolvas[i].Split(" ")[1]);
////        }

////        if (z == 270)
////        {
////            y -= int.Parse(beolvas[i].Split(" ")[1]);
////        }
////    }

////    if (beolvas[i].Contains("left"))
////    {
////        z -= int.Parse(beolvas[i].Split(" ")[1]);
////        if (z < 0)
////        {
////            z = 360 + z;
////        }
////    }

////    if (beolvas[i].Contains("right"))
////    {
////        z += int.Parse(beolvas[i].Split(" ")[1]);
////        if (z > 360)
////        {
////            z = z - 360;
////        }
////    }
////}

////Console.WriteLine($"Módosult kimenetem: {x}, {y}, {z}");

////4

//StreamReader reader = new StreamReader("NHANES_1999-2018.csv");
////1
//double summaBMIFerfi = 0;
//double countBMIFerfi = 0;

//double summaBMINoi = 0;
//double countBMINoi = 0;

////2
//double countLargerThenFiveSixNo = 0;

////3
//double maxBMI = 0;
//double maxBMIVercukor = 0;

////4
//double harmincasBmiEletkor = 0;
//double countHarmincasBmiEletkor = 0;

//string line;
//line = reader.ReadLine(); //első sort átugorjuk, mivel nem tartalmaz számunkra tényleges adatot
//while ((line = reader.ReadLine()) != null)
//{

//    string[] sor = line.Split(",");
//    //1
//    if (double.Parse(sor[2], CultureInfo.InvariantCulture) == 1.0)
//    {
//        summaBMIFerfi += double.Parse(sor[4], CultureInfo.InvariantCulture);
//        countBMIFerfi++;
//    }

//    if (double.Parse(sor[2], CultureInfo.InvariantCulture) == 2.0)
//    {
//        summaBMINoi += double.Parse(sor[4], CultureInfo.InvariantCulture);
//        countBMINoi++;
//    }

//    //2
//    if (double.Parse(sor[5], CultureInfo.InvariantCulture) > 5.6)
//    {
//        countLargerThenFiveSixNo++;
//    }

//    //3
//    if (double.Parse(sor[4], CultureInfo.InvariantCulture) > maxBMI)
//    {
//        maxBMI = double.Parse(sor[4], CultureInfo.InvariantCulture);
//        maxBMIVercukor = double.Parse(sor[5], CultureInfo.InvariantCulture);
//    }

//    //4
//    if (double.Parse(sor[4], CultureInfo.InvariantCulture) >= 30)
//    {
//        harmincasBmiEletkor += double.Parse(sor[3], CultureInfo.InvariantCulture);
//        countHarmincasBmiEletkor++;
//    }

//}

//Console.WriteLine($"1. feladat\n" +
//    $"Testtömegindex férfi: {summaBMIFerfi / countBMIFerfi}\n" +
//    $"Testtömegindex női: {summaBMINoi / countBMINoi}");

//Console.WriteLine($"2. feladat\n" +
//    $"Nők kiknek vércukorszinte nagyobb mint 5.6: " +
//    $"{countLargerThenFiveSixNo / countBMINoi * 100}");

//Console.WriteLine($"3. feladat\n" +
//    $"Max BMI-vel rendelkező személy adatai: \n" +
//    $"BMI szintje: {maxBMI}\n" +
//    $"Vércukorszintje: {maxBMIVercukor}");

//Console.WriteLine($"4. feladat\n" +
//    $"Legalább 30-as BMI értékkel rendelkező személyek átlagos életkora: " +
//    $"{harmincasBmiEletkor / countHarmincasBmiEletkor}");