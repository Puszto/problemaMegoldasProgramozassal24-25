using System.Runtime;

namespace progMegoldas3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1

            //string[] aTomb = new string[52];
            //int aktualIndex = 0;
            //int lefutas = 0;
            //string magassag = "Kör";

            //while (lefutas < 4)
            //{
            //    if (lefutas == 1)
            //    {
            //        magassag = "Káró";
            //    }

            //    else if (lefutas == 2)
            //    {
            //        magassag = "Treff";
            //    }

            //    else if (lefutas == 3)
            //    {
            //        magassag = "Pikk";
            //    }

            //    for (int i = 2; i <= 14; i++)
            //    {
            //        if (i == 14)
            //        {
            //            aTomb[aktualIndex] = $"{magassag} Ász";
            //        }

            //        else if (i == 13)
            //        {
            //            aTomb[aktualIndex] = $"{magassag} Király";
            //        }

            //        else if (i == 12)
            //        {
            //            aTomb[aktualIndex] = $"{magassag} Dáma";
            //        }

            //        else if (i == 11)
            //        {
            //            aTomb[aktualIndex] = $"{magassag} Jumbó";
            //        }

            //        else
            //        {
            //            aTomb[aktualIndex] = $"{magassag} {i}";
            //        }
            //        aktualIndex++;
            //    }

            //    lefutas++;
            //}

            //foreach (string x in aTomb)
            //{
            //    Console.WriteLine(x);
            //}


            ////2
            //Random rnd = new Random();
            //for (int i = 0; i < aTomb.Length; i++)
            //{
            //    int j = rnd.Next(i, aTomb.Length);
            //    string tarolo = aTomb[j];
            //    aTomb[j] = aTomb[i];
            //    aTomb[i] = tarolo;
            //}

            //foreach (string x in aTomb)
            //{
            //    Console.WriteLine(x);
            //}


            ////3
            //string[] szotar = new string[5];
            //int szamlalo = 0;
            //while (szamlalo < 5)
            //{
            //    Console.Write("Kérem adjon meg egy szót: ");
            //    string bemenet = Console.ReadLine();
            //    szotar[szamlalo] = bemenet;
            //    szamlalo++;
            //}

            //Console.Write("\nKérem adja meg a keresett szót: ");
            //string keresett = Console.ReadLine();
            //bool van = false;

            //int i = 0;
            //while(i < szotar.Length && van == false)
            //{
            //    if (szotar[i] == keresett)
            //    {
            //        Console.WriteLine($"\nBenne van.\n{(i + 1)}. helyen található\n");
            //        van = true;
            //    }
            //    i++;
            //}

            //if (!van)
            //{
            //    Console.WriteLine("\nA keresett szó nincs benne.");
            //}


            ////4
            //List<string> lista = new List<string>();
            //int szamlalo = 0;
            //string bemenet = "";

            //do
            //{
            //    Console.Write("Kérem adjon meg egy szót: ");
            //    bemenet = Console.ReadLine();

            //    if (bemenet.ToLower() != "stop")
            //    {
            //        lista.Add(bemenet);
            //    }

            //} while (bemenet.ToLower() != "stop");

            //Console.Write("Kérem adja meg a keresett szót: ");
            //string keresett = Console.ReadLine();
            //int i = 0;
            //bool van = false;

            //while (i < lista.Count && van == false)
            //{
            //    if (lista[i] == keresett)
            //    {
            //        Console.WriteLine($"\nBenne van.\n{(i + 1)}. helyen található\n");
            //        van = true;
            //    }
            //    i++;
            //}

            //if (!van)
            //{
            //    Console.WriteLine("\nA keresett szó nincs benne.");
            //}

            ////5
            //List<string> nevek = new List<string>();
            //List<int> eletkorok = new List<int>();
            //List<bool> tapasztalatok = new List<bool>();

            //int szamlalo = 0;
            //Console.Write("Kérem adja meg a nevét: ");
            //string nev = Console.ReadLine();

            //while (nev != "")
            //{
            //    nevek.Add(nev);

            //    Console.Write("Kérem adja meg az életkorát: ");
            //    int eletkor = int.Parse(Console.ReadLine());
            //    eletkorok.Add(eletkor);

            //    Console.Write("Kérem adja meg volt-e tapasztalata: ");
            //    bool tapasztalat = bool.Parse(Console.ReadLine());
            //    tapasztalatok.Add(tapasztalat);

            //    szamlalo++;

            //    Console.Write("Kérem adja meg a nevét: ");
            //    nev = Console.ReadLine();
            //}

            ////Átlagéletkor
            //double atlagkor = 0;
            //foreach (int kor in eletkorok)
            //{
            //    atlagkor += kor;
            //}

            //Console.WriteLine($"\nÁtlagéletkor a teljes listában: {atlagkor / nevek.Count}");

            ////Átlagéletkor - programozói tapasztalat nélküli személyek között
            //double atlagkorNemTudok = 0;
            //double szamlaloEletkorNemTudok = 0;
            //for (int i = 0; i < nevek.Count; i++)
            //{

            //    if (!tapasztalatok[i])
            //    {
            //        atlagkorNemTudok += eletkorok[i];
            //        szamlaloEletkorNemTudok++;
            //    }
            //}

            //Console.WriteLine($"\nÁtlagéletkor programozni nem tudók között: {atlagkorNemTudok / szamlaloEletkorNemTudok}");

            ////Legidősebb progos személy

            //int eletkorMaxProgos = 0;
            //int elektorMaxIndex = 0;

            //for (int i = 0; i < nevek.Count; i++)
            //{
            //    if (tapasztalatok[i] && eletkorok[i] > eletkorMaxProgos)
            //    {
            //        eletkorMaxProgos = eletkorok[i];
            //        elektorMaxIndex = i;
            //    }
            //}

            //if (eletkorMaxProgos == 0)
            //{
            //    Console.WriteLine("\nNem volt programozói tapasztalattal rendelkező személy.");
            //}

            //else
            //{
            //    Console.WriteLine($"\nLegidősebb programozói tapasztalattal rendelkező neve: {nevek[elektorMaxIndex]}\nKora: {eletkorMaxProgos}");
            //}



            ////6
            ////--->MEGJEGYZÉS<---
            ////MÁTRIXOK LÉTREHOZÁSA KÜLÖNBÖZŐ MÓDON
            ////ELSŐ MEGADÁS
            ////char[,] matrix = 
            ////{
            ////    {'a', 'b', 'c', 'd'},
            ////    {'e', 'f', 'g', 'h'},
            ////    {'i', 'j', 'k', 'l'}
            ////};

            ////MÁSODIK MEGADÁS
            ////char[,] matrix = new char[3, 4]; //3 sorból és 4 oszlopból álló mátrix
            ////string characters = "abcdefghijkl";

            ////int index = 0;
            ////for (int i = 0; i < 3; i++)
            ////{
            ////    for (int j = 0; j < 4; j++)
            ////    {
            ////        matrix[i, j] = characters[index];
            ////        index++;
            ////    }
            ////}

            ////i. sor j. elemének értékadás
            ////string[,] matrix = new string[3, 4]; //3 sorból és 4 oszlopból álló mátrix
            ////matrix[0, 1] = "cica";    // 0. sor, 1. oszlop
            ////matrix[1, 3] = "delfin";  // 1. sor, 3. oszlop
            ////------------------


            //char[,] adatok = 
            //{
            //    {'a', 'b', 'c', 'd'},
            //    {'e', 'f', 'g', 'h'},
            //    {'i', 'j', 'k', 'l'}
            //};

            //GetLength(0) visszaadja a sorok számát
            //GetLength(1) visszaadja az oszlopok számát

            //for (int i = 0; i < adatok.GetLength(1); i++)
            //{
            //    for (int j = 0; j < adatok.GetLength(0); j++)
            //    {
            //        Console.Write(adatok[j,i]+" ");
            //    }
            //    Console.WriteLine("");
            //}


            //////7

            //string[,] halak =
            //{
            //    {"", "Menyhal","Harcsa", "Dottyback"},
            //    {"Józsi", "", "", ""},
            //    {"Sándor", "", "", ""},
            //    {"Dávid", "", "", ""}
            //};

            //int lefutas = (halak.GetLength(0) - 1) * (halak.GetLength(1) - 1);
            //Random random = new Random();

            ////Véletlen táblázat értékek generálása
            //while (lefutas > 0)
            //{
            //    int i = random.Next(1, 4);
            //    int j = random.Next(1, 4);

            //    if (halak[i, j] == "")
            //    {
            //        halak[i, j] = random.Next(0, 20).ToString();
            //        lefutas--;
            //    }
            //}

            ////Formázott megjelenítés
            //for (int i = 0; i < halak.GetLength(0); i++)
            //{
            //    for (int j = 0; j < halak.GetLength(1); j++)
            //    {
            //        Console.Write(halak[i, j] + "\t");
            //    }
            //    Console.WriteLine("");
            //}

            ////Fogások halfajonként
            //int countMennyhal = 0;
            //int countHarcsa = 0;
            //int countDottyback = 0;

            //int lefutasCounter = 1;

            //while (lefutasCounter < 4)
            //{
            //    for (int j = 1; j < halak.GetLength(0); j++)
            //    {
            //        if (lefutasCounter == 1)
            //        {
            //            countMennyhal += int.Parse(halak[j, lefutasCounter]);
            //        }

            //        else if (lefutasCounter == 2)
            //        {
            //            countHarcsa += int.Parse(halak[j, lefutasCounter]);
            //        }

            //        else if (lefutasCounter == 3)
            //        {
            //            countDottyback += int.Parse(halak[j, lefutasCounter]);
            //        }
            //    }

            //    lefutasCounter++;
            //}

            //Console.WriteLine($"\nMenyhal: {countMennyhal}\nHarcsa: {countHarcsa}\nDottyback: {countDottyback}");

            ////Legtöbb adott horgász által fogott hal
            //string maxName = "";
            //int maxFogas = 0;

            //for (int i = 1; i < halak.GetLength(0); i++)
            //{
            //    int sum = 0;

            //    for (int j = 1; j < halak.GetLength(1); j++)
            //    {
            //        sum += int.Parse(halak[i, j]);
            //    }

            //    if (sum > maxFogas)
            //    {
            //        maxFogas = sum;
            //        maxName = halak[i,0];
            //    }
            //}

            //Console.WriteLine($"\nLegtöbb halat fogó horgász: {maxName}\nKifogott halak: {maxFogas}");

            //bool volt = false;
            //int sorok = 1;

            //while(!volt && sorok < halak.GetLength(0))
            //{
            //    for (; sorok < halak.GetLength(0); sorok++)
            //    {
            //        int sum = 0;

            //        for (int j = 1; j < halak.GetLength(1); j++)
            //        {
            //            sum += int.Parse(halak[sorok, j]);
            //        }

            //        if (sum == 0)
            //        {
            //            volt = true;
            //        }
            //    }
            //}

            //if (volt)
            //{
            //    Console.WriteLine("\nVolt olyan horgász, ki egyetlen halat sem fogott.");
            //} else
            //{
            //    Console.WriteLine("\nNem volt olyan horgász, aki egyetlen halat sem fogott volna.");
            //}

            ////8
            //Console.Write("Kérem adjon meg egy pozitív egész számot: ");
            //double bemenet = double.Parse(Console.ReadLine());
            //List<double> adatok = new List<double>();

            //double K = bemenet;
            //while (K > 1)
            //{
            //    if (K % 2 == 0)
            //    {
            //        adatok.Add(K / 2);
            //        K = K / 2;
            //    }

            //    else
            //    {
            //        adatok.Add((3 * K + 1));
            //        K = 3 * K + 1;
            //    }
            //}

            //for (int i = 0; i < adatok.Count; i++)
            //{
            //    Console.WriteLine(adatok[i]);
            //}


            ////9
            //Ha nem osztasz 2-vel, akkor rendezi a tömböt fordítottan, majd vissza rendezi azt az eredeti állapotába
            //x[x.Lenth - i] helytelen, mert túl mutat a tömbön, ki kell még vonni 1-et.

            //int[] x = { 1, 2, 3, 4, 5, 6, 7, 8};
            //for (int i = 0; i < x.Length / 2; i++)
            //{
            //    int tmp = x[i];
            //    x[i] = x[x.Length - i - 1];
            //    x[x.Length - i - 1] = tmp;
            //}

            ////10
            //Console.Write("Hány elemű legyen a tömb: ");
            //int meret = int.Parse(Console.ReadLine());

            //int[] randomInt = new int[meret];
            //Random random = new Random();

            //for (int i = 0; i < meret; i++)
            //{
            //    randomInt[i] = random.Next(0, 100);
            //}

            ////Minden második elem kiválogatása

            //List<int> mindenMasodik = new List<int>();
            //for (int i = 2; i < meret; i += 2)
            //{
            //    mindenMasodik.Add(randomInt[i]);
            //}

            //foreach (int x in mindenMasodik)
            //{
            //    Console.WriteLine(x);
            //}

            ////Kiválogatott elemek megfordítása
            //for (int i = 0; i < mindenMasodik.Count / 2; i++)
            //{
            //    int tmp = mindenMasodik[i];
            //    mindenMasodik[i] = mindenMasodik[mindenMasodik.Count - 1 - i];
            //    mindenMasodik[mindenMasodik.Count - 1 - i] = tmp;
            //}

            //Console.WriteLine();
            //foreach (int x in mindenMasodik)
            //{
            //    Console.WriteLine(x);
            //}

            ////Lehető legkisebb négyzetes mátrixba történő rendezés
            ////--->MEGJEGYZÉS<---
            ////double elso = 3.16;
            ////Console.WriteLine(Math.Ceiling(elso)); //Ez mindig felfele kerekít, tehát 3.16 esetén 4-re kerekít
            ////Console.WriteLine(Math.Round(elso));   //Ez meg követi a kerekítési szabályokat. 3.5-től felfele, tehát 4-re,
            ////3.5 alatt pedig 3-ra
            ////Console.WriteLine(Math.Floor(elso));   //Ez mindig lefele kerekít, tehát 3.75 esetén 3-ra kerekít
            ////------------------

            //int negyzetesMatrix = (int)Math.Ceiling(Math.Sqrt(mindenMasodik.Count));

            //int[,] negyzetes = new int[negyzetesMatrix, negyzetesMatrix];
            //int index = 0;
            //for (int i = 0; i < negyzetes.GetLength(0); i++)
            //{
            //    for (int j = 0; j < negyzetes.GetLength(1); j++)
            //    {
            //        if (index < mindenMasodik.Count)
            //        {
            //            negyzetes[i, j] = mindenMasodik[index];
            //            index++;
            //        }

            //        else
            //        {
            //            negyzetes[i, j] = 0;
            //        }
            //    }
            //}
            //Console.WriteLine();

            //for (int i = 0; i < negyzetes.GetLength(0); i++)
            //{
            //    for (int j = 0; j < negyzetes.GetLength(1); j++)
            //    {
            //        Console.Write(negyzetes[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            ////11
            //Console.Write("Adja meg, hogy hány dimenziós legyen a tömb (pl.: 3): ");
            //int tarolo = int.Parse(Console.ReadLine());

            //int[,] forgatas = new int[tarolo, tarolo];
            //int idx = 1;

            //for (int i = 0; i < forgatas.GetLength(0); i++)
            //{
            //    for (int j = 0; j < forgatas.GetLength(1); j++)
            //    {
            //        forgatas[i, j] = idx;
            //        Console.Write(forgatas[i, j] + "\t");
            //        idx++;
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //int[,] forgatasUtan = new int[forgatas.GetLength(0), forgatas.GetLength(1)];

            //int n = forgatas.GetLength(0);
            //int lefutas = n / 2;

            //for (int layer = 0; layer < lefutas; layer++)
            //{
            //    int sorStart = layer;
            //    int sorEnd = n - 1 - layer;
            //    int oszlopStart = layer;
            //    int oszlopEnd = n - 1 - layer;

            //    //Külső réteg elemek összegyűjtése
            //    List<int> borderElements = new List<int>();

            //    //Felső sor (balról jobbra)
            //    for (int i = oszlopStart; i <= oszlopEnd; i++)
            //    {
            //        borderElements.Add(forgatas[sorStart, i]);
            //    }

            //    //Jobb oszlop (fentről lefelé, kivéve a sarkot)
            //    for (int i = sorStart + 1; i <= sorEnd; i++)
            //    {
            //        borderElements.Add(forgatas[i, oszlopEnd]);
            //    }

            //    //Alsó sor (jobbról balra)
            //    for (int i = oszlopEnd - 1; i >= oszlopStart; i--)
            //    {
            //        borderElements.Add(forgatas[sorEnd, i]);
            //    }

            //    //Bal oszlop (lentről felfelé, kivéve a sarkokat)
            //    for (int i = sorEnd - 1; i > sorStart; i--)
            //    {
            //        borderElements.Add(forgatas[i, oszlopStart]);
            //    }

            //    //Ciklikus eltolás
            //    borderElements.Insert(0, borderElements[borderElements.Count - 1]);
            //    borderElements.RemoveAt(borderElements.Count - 1);

            //    //Visszaírás a mátrixba az új eltolás után
            //    int index = 0;

            //    //Felső sor (balról jobbra)
            //    for (int i = oszlopStart; i <= oszlopEnd; i++)
            //    {
            //        forgatasUtan[sorStart, i] = borderElements[index++];
            //    }

            //    // Jobb oszlop (fentről lefelé)
            //    for (int i = sorStart + 1; i <= sorEnd; i++)
            //    {
            //        forgatasUtan[i, oszlopEnd] = borderElements[index++];
            //    }

            //    //Alsó sor (jobbról balra)
            //    for (int i = oszlopEnd - 1; i >= oszlopStart; i--)
            //    {
            //        forgatasUtan[sorEnd, i] = borderElements[index++];
            //    }

            //    // Bal oszlop (lentről felfelé)
            //    for (int i = sorEnd - 1; i > sorStart; i--)
            //    {
            //        forgatasUtan[i, oszlopStart] = borderElements[index++];
            //    }
            //}

            ////Másoljuk át a középső elemet, ha a mátrix mérete páratlan
            //if (n % 2 == 1)
            //{
            //    int kozep = n / 2;
            //    forgatasUtan[kozep, kozep] = forgatas[kozep, kozep];
            //}

            ////Eredmény kiírása
            //for (int i = 0; i < forgatasUtan.GetLength(0); i++)
            //{
            //    for (int j = 0; j < forgatasUtan.GetLength(1); j++)
            //    {
            //        Console.Write(forgatasUtan[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}