internal class Program
{
    private static void Main(string[] args)
    {
        ////1
        //Console.WriteLine("Hello, World!");


        ////2
        //Console.WriteLine("Szia uram");
        //Console.Clear();

        //Console.WriteLine(Console.WindowWidth);
        //Console.WriteLine(Console.WindowHeight);

        //Console.WindowWidth = 20;
        //Console.WindowHeight = 20;

        //Console.BackgroundColor = ConsoleColor.Black;
        //Console.ForegroundColor = ConsoleColor.Yellow;

        //Console.SetCursorPosition(10, 10);

        //Console.CursorVisible = false;


        ////--> VÁLTOZÓK <--
        ////int -> egész számok tárolására szolgál
        ////Példa: 
        //int szam = 10;
        //Console.WriteLine(szam);

        ////double -> lebegőpontos azaz tizedesjegyes számok tárolására szolgál
        ////Példa:
        //double tizedes = 3.14;
        //Console.WriteLine(tizedes);

        ////string -> szöveges mező tárolására szolgál
        ////Példa: 
        //string szoveg = "bemenet";
        //Console.WriteLine(szoveg);

        ////char -> egy adott karaktert tudok vele letárolni
        ////Példa: 
        //char karakter = 'a'; //fontos, hogy '' között adjuk a karaktert és szigorúan csak 1db karaktert
        ////adhatunk meg.
        //Console.WriteLine(karakter);

        ////bool -> logikai értékek tárolására szolgál. El lehet benne tárolni feltételek igazságértékét
        ////Példa: 
        //bool logika = false;
        //bool logika2 = true;
        //Console.WriteLine(logika);
        //Console.WriteLine(logika2);

        //bool logika3 = (12 > 3); //12 nagyobb mint 3? Igen, tehát igaz. logika3 értéke igaz lesz.
        //Console.WriteLine(logika3);

        ////--> ToString() <--
        ////Bármely típusú adat szöveggé alakítható.
        //Példa: 
        //int szam = 123;
        //string text = szam.ToString(); //textbe eltároltam a szam változó értékét,
        ////csak átalakítottam szöveggé a ToString() segítségével.

        ////--> Hozzáfűzés stringhez <--
        //string szoveg1 = "Fernando";
        //string szoveg2 = "Alonso";
        //string egybe = szoveg1 + " " + szoveg2;
        //Console.WriteLine(egybe); //Eredményem: Fernando Alonso

        ////modernebb megoldás
        //string egybe2 = $"{szoveg1} {szoveg2}";
        //Console.WriteLine(egybe);

        ////--> PÉLDÁK <--
        //int szam; //<- deklarálás: létrehozunk egy változót, de nem adunk neki egy konkrét értéket
        //szam = 10; //<- értékadás: az előbb létrehozott szám változónkhoz rendelünk hozzá egy konkrét értéket.

        //int szam2 = 20; //<- inicializálás: deklarálás és értékadás kombinációja

        ////--> PARSE <--
        ////Ennek segítségével vagyunk képesek átalakítani szöveget valamilyen más típussá mint
        ////pl.: int, char, double stb..
        ////Példa:
        //int szam = int.Parse("123"); //szöveget "123"-at egész számmá alakítottuk át

        //double tizedes = double.Parse("3,145"); //szöveget "123"-at egész számmá alakítottuk át
        ////Nyelv függő, hogy double.Parse("3,145") esetében vesszőt (,) vagy pontot (.) adunk meg tizedesjegyek
        ////elválasztására. Magyarba alapértelmezetten vessző (,);

        //char karakter = char.Parse("K"); //szöveget "K"-t karakterré alakítottuk át 

        ////--> Típuskonverzió <--
        ////Explicit típuskonverzió: Adatvesztéses, nagyobb típusból kisebb típusba kényszerítünk, ekkor
        ////nekünk kell manuálisan beavatkozni, ki kell kényszszerítenünk a castolást.
        ////Példa: 
        //double szam1 = 3.86;
        //int szam2 = (int)szam1; //szam2-ben el lesz tárolva a 3. Viszont a 0.86 az elveszik.

        ////Implicit típuskonverzió: Kisebb típusból nagyobb típusba történik az átalakítás, ekkor nincs adatvesztés.
        //Példa: 
        //int szam1 = 10;
        //double szam2 = szam1; //szam2 értéke: 10.0 -> nem történt adatvesztés


        ////3
        //Console.Write("Kérlek, add meg a neved: ");
        //string myName = Console.ReadLine();

        //if (string.IsNullOrWhiteSpace(myName)) //Ha szeretnék ellenőrizni, ha bemenet egy "space" vagy egyátalán semmi nincs megadva
        //{
        //    Console.WriteLine("Hibás név - nem adhatsz meg üres mezőt.");
        //}
        //else
        //{
        //    Console.WriteLine($"Üdvözöllek {myName}");
        //}


        ////4
        //Console.Write("Kérlek, add meg a születési évedet: ");
        //int szulEv = int.Parse(Console.ReadLine());

        //if (szulEv > 0)
        //{
        //    Console.WriteLine($"Életkorod: {DateTime.Now.Year - szulEv}"); //DateTime.Now.Year -> Gép helyi beállított dátom és idő alapján adja vissza a jelenlegi évet
        //}

        //else
        //{
        //    Console.WriteLine($"Hibás értéket adtál meg");
        //}


        ////5
        //Console.Write("Add meg a testmagasságodat méterben: ");
        //double h = double.Parse(Console.ReadLine());

        //Console.Write("Add meg a testsúlyodat kilógarammban: ");
        //double m = double.Parse(Console.ReadLine());

        //double bmi = m / (h * h);

        //Console.WriteLine($"Testömegindexed: {bmi}");


        ////6

        //Console.Write("Adj meg másodpercben egy időtartamot: ");
        //int masodperc = int.Parse(Console.ReadLine());

        //int perc = masodperc / 60;
        //int masodpercValtozo = masodperc % 60;
        //string tarolo = "";

        //if (masodpercValtozo >= 0 && masodpercValtozo <= 9)
        //{
        //    tarolo = "0" + masodpercValtozo;
        //    tarolo = masodpercValtozo.ToString("D5");
        //}

        //Console.WriteLine($"Az időtartam formázva: {perc}:{masodpercValtozo:D2}");


        ////7
        //Console.Write("Adjon meg egy jelszót: ");
        //string jelszo = Console.ReadLine();

        //Console.Write("Adja meg ismét a jelszót: ");
        //string jelszo2 = Console.ReadLine();

        //if (jelszo == jelszo2)
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("A két jelszó megegyezik");
        //} else
        //{
        //    Console.ForegroundColor= ConsoleColor.Red;
        //    Console.WriteLine("A két jelszó nem egyezik meg");
        //}
        //Console.ResetColor(); //Alapértelmezettre állítja vissza szövegnek a színét.


        ////9

        //Console.Write("Kérlek add meg az első számot: ");
        //int szam1 = int.Parse(Console.ReadLine());

        //Console.Write("Kérlek add meg az második számot: ");
        //int szam2 = int.Parse(Console.ReadLine());

        //Console.Write("Kérlek add meg a műveletet: ");
        //string muvelet = Console.ReadLine();

        //if (muvelet == "+")
        //{
        //    Console.WriteLine($"{szam1} {muvelet} {szam2} = {szam1 + szam2}");
        //}

        //else if (muvelet == "-")
        //{
        //    Console.WriteLine($"{szam1} {muvelet} {szam2} = {szam1 - szam2}");
        //}

        //else if (muvelet == "*")
        //{
        //    Console.WriteLine($"{szam1} {muvelet} {szam2} = {szam1 * szam2}");
        //}

        //else if (muvelet == "/")
        //{
        //    if (szam2 == 0)
        //    {
        //        Console.WriteLine("HIBA! -> Nullával való osztás nem érvényes.");
        //    } else
        //    {
        //        Console.WriteLine($"{szam1} {muvelet} {szam2} = {szam1 / szam2}");
        //    }
        //}


        ////11
        //Console.Write("Kérem adjon meg egy számot 0 és 9 között: ");
        //int bekertSzam = int.Parse(Console.ReadLine());

        //if (bekertSzam == 0)
        //{
        //    Console.WriteLine("Nulla");
        //}

        //else if (bekertSzam == 1)
        //{
        //    Console.WriteLine("Egy");
        //}

        //else if (bekertSzam == 2)
        //{
        //    Console.WriteLine("Kettő");
        //}

        //else if (bekertSzam == 3)
        //{
        //    Console.WriteLine("Három");
        //}

        //else if (bekertSzam == 4)
        //{
        //    Console.WriteLine("Négy");
        //}

        //else if (bekertSzam == 5)
        //{
        //    Console.WriteLine("Öt");
        //}

        //else if (bekertSzam == 6)
        //{
        //    Console.WriteLine("Hat");
        //}

        //else if (bekertSzam == 7)
        //{
        //    Console.WriteLine("Hét");
        //}

        //else if (bekertSzam == 8)
        //{
        //    Console.WriteLine("Nyolc");
        //}

        //else if (bekertSzam == 9)
        //{
        //    Console.WriteLine("Kilenc");
        //}

        //else
        //{
        //    Console.WriteLine("Az érték a tartományon kívül esett.");
        //}


        ////12
        //Console.Write("Kérlek, adj meg egy betűt: ");
        //char betu = char.Parse(Console.ReadLine());

        //if (betu == 'a' || betu == 'á' || betu == 'e' || betu == 'é' || betu == 'i' || betu == 'í' 
        //    || betu == 'o' || betu == 'ó' || betu == 'ö' || betu == 'ő' || betu == 'u' || betu == 'ú' ||
        //    betu == 'ü' || betu == 'ű')
        //{
        //    Console.WriteLine("Magánhangzó");
        //}

        //else
        //{
        //    Console.WriteLine("Mássalhangzó");
        //}

        ////logikai operátorok:
        //// ---> || <--- VAGY logikai operátor: célja, hogy két feltételt hasonlít össze és akkor ad
        ////vissza true értéket, ha legalább egyik feltétel igaz lesz.

        //// ---> && <--- ÉS logikai operátor: célja, hogy két feltétel hasonlít össze és akkor ad
        ////vissza true értéket, ha minden feltétel teljesül.

        //// ---> ! <--- NEGÁLÁS: Egy feltétel igazságértékét fordítja meg. Ha valami igaz és negálom, akkor
        ////hamisat kapok, ugyanez igaz fordítva is, ha valami hamis és negálom, akkor igazat kapok.
        ////
        //// Ha , például vizsgálunk egy olyat, hogy a szám nagyobb mint 0, 
        ////de kisebb mint 9, ennek veszem a negáltját, akkor a következőt kapjuk.
        ////Ha a feltételünk igaz, tehát, szám nagyobb mint 0 és a szám kisebb mint 9, akkor ha ennek veszem a 
        ////negáltját, akkor hamisat kapok. Tehát akkor fog lefutni a feltételemhez tartozó belső utasítási blokk,
        ////ha hamis a feltételem eredménye.
        ////Példával:

        //int szam = 20;
        //if (!(szam > 0 && szam < 9))
        //{
        //    Console.WriteLine($"Valóban, a(z) {szam} az nem 0 és 9 közé esik.");
        //} else
        //{
        //    Console.WriteLine($"Valóban, a(z) {szam} az 0 és 9 közé esik.");
        //}

        ////Tehát ebben az esetben pedig akkor fog lefutni az első feltételem belső utasítás blokkja, ha a
        ////feltételünk hamis.
        ////Hogy is van ez? Jelen esetben az 5 az valóban nagyobb mint 0 és kisebb mint 9, akkor igaznak
        ////kéne lennie nem? Igaz is lesz, de mivel negálom, ezért hamis lesz. Tehát akkor fog lefutni a 
        ////belső utasítás blokk, ha az egész feltételem hamis. 

        ////13
        //int V = 100;
        //int R1 = 100;
        //int R2 = 100;
        //double T = 2.5;

        //double szorzat = (R1 * T) + (R2 * T);

        //if ((szorzat > V))
        //{
        //    Console.WriteLine($"--> A tartály {szorzat - V} m3-rel lesz túltöltve.");
        //}
        //else
        //{
        //    Console.WriteLine($"--> A tartály {(szorzat / V) * 100}%-ban lesz tele.");
        //}






        ////EXTRA - Swich case
        ////Kevésbé rugalmas mint az if else, kimondottan csak egyenlőség vizsgálatra lehet használni, hogy 
        ////megegyezik-e egy adott értékkel vagy sem. Összetettebb feltételek, tehát pl.: tartományok vizsgálata,
        ////logikai kifejezéseket, függvényeredményeket nem tud kezelni. 

        ////KONKRÉT PÉLDA
        ////1)
        ////Életkor vizsgálat, bizonyos kornál idősebb, bizonyos kornál fiatalabb, melyik lenne
        ////a jobb, sima if else, vagy swich case?
        ////Ebben az esetben if else.

        ////2)
        ////Jelszó vizsgálat, adott bekért jelszó megegyezik-e a felhasználó jelszavával.
        ////Erre az esetre tökéletes nekünk a swich case


        ////11-es feladat swich case segítségével
        //Console.Write("Kérem, adjon meg egy számot 0 és 9 között: ");
        //int szam = int.Parse(Console.ReadLine());

        //switch (szam)
        //{
        //    case 0:
        //        Console.WriteLine("nulla"); break;
        //    case 1:
        //        Console.WriteLine("egy"); break;
        //    case 2:
        //        Console.WriteLine("kettő"); break;
        //    case 3:
        //        Console.WriteLine("három"); break;
        //    case 4:
        //        Console.WriteLine("négy"); break;
        //    case 5:
        //        Console.WriteLine("őt"); break;
        //    case 6:
        //        Console.WriteLine("hat"); break;
        //    case 7:
        //        Console.WriteLine("hét"); break;
        //    case 8:
        //        Console.WriteLine("nyolc"); break;
        //    case 9:
        //        Console.WriteLine("kilenc"); break;
        //}

        ////12-es feladat swich case segítségével
        //Console.Write("Kérlek, adj meg egy betűt: ");
        //char betu = char.Parse(Console.ReadLine());

        //switch(betu)
        //{
        //    case 'a': Console.WriteLine("Magánhangzó"); break;
        //    case 'á': Console.WriteLine("Magánhangzó"); break;
        //    case 'e': Console.WriteLine("Magánhangzó"); break;
        //    case 'é': Console.WriteLine("Magánhangzó"); break;
        //    case 'i': Console.WriteLine("Magánhangzó"); break;
        //    case 'í': Console.WriteLine("Magánhangzó"); break;
        //    case 'o': Console.WriteLine("Magánhangzó"); break;
        //    case 'ó': Console.WriteLine("Magánhangzó"); break;
        //    case 'ö': Console.WriteLine("Magánhangzó"); break;
        //    case 'ő': Console.WriteLine("Magánhangzó"); break;
        //    case 'u': Console.WriteLine("Magánhangzó"); break;
        //    case 'ú': Console.WriteLine("Magánhangzó"); break;
        //    case 'ü': Console.WriteLine("Magánhangzó"); break;
        //    case 'ű': Console.WriteLine("Magánhangzó"); break;
        //    default: Console.WriteLine("Mássalhangzó"); break; 
        ////default: Alapértelmezett eset, ha egyik eset sem felel meg a fentebb felsoroltak közül,
        ////akkor a default fog lefutni. Olyan mint az else lényegében.
        //}
    }
}