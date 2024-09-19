using System.Drawing;

namespace progMegoldasDemo02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /////Kezdés
            /////Ciklusok: 
            /////Megkülönböztetünk elől és hátultesztelős ciklusokat
            /////Hátultesztelős ciklus a "do while"
            /////Elöltesztelős ciklus a "while" valamint a "for" (kezdetekben elég nekünk ezt a 3 ciklust tudni)
            /////
            /////Hátultesztelős ciklus
            /////--->DO WHILE <---
            /////A ciklus utasításai legalább egyszer mindenképpen lefutnak, mielőtt a feltétel ellenőrzésre kerül.
            /////Akkor használjuk, amikor a ciklus magjának legalább egyszer le kell futnia. Tipikus példa lehet jelszóösszehasonlítás, 
            /////amikor először mindenképpen bekérünk egy jelszót, majd ellenőrizzük, hogy az helyes-e.
            /////Felépítése: 
            /////do 
            /////{
            /////A do blokk legalább egyszer lefut, bekér egy jelszót.
            /////}
            /////while(A while feltétel csak ezután ellenőrzi, hogy a megadott jelszó helyes-e, ha nem, újra futtatja a ciklus magját.);
            /////

            /////
            /////Elöltesztelős ciklus: 
            /////--->For ciklus<---
            /////Elsődlegesen számlálásra használjuk. Az elején megadunk egy kezdőértéket, egy feltételt és egy lépésközt, 
            /////amelyek alapján a ciklus futni fog.
            /////Gyakran akkor használjuk, amikor ismert, hogy hányszor kell futnia a ciklusnak, például tömb elemeinek bejárásakor.
            /////pl.: (páros és páratlan számok kiíratására egy tömbből)
            /////Felépítése: 
            /////for(kezdőérték pl.: i = 0; feltétel pl.: i < 10; lépésköz pl.: i++)
            /////{
            /////ciklusmag
            /////} 
            /////
            /////Felépítése magyarázat nélkül: 
            /////for(int i = 0; i < 10, i++)
            /////{
            /////
            /////}
            /////Van egy i változónk aminek kezdőértéke 0.
            /////Feltételünk, hogy az i változó értékének kisebbnek kell lennie mint 10
            /////Ha a feltételünk teljesül, akkor növeljük az i értékét 1-gyel.
            ///// 
            ///// MEGJEGYZÉS: i++ az ugyanaz mint az i = i + 1 csak rövidebb
            /////
            /////--->While ciklus<---
            /////Először a feltételt vizsgálja meg, és ha az igaz, akkor futtatja a ciklus magját. Ha a feltétel az elején hamis, a ciklus egyszer sem fut le.
            /////Olyan helyzetekben célszerű, amikor nem tudjuk előre, hányszor kell végrehajtani a ciklust, de egy feltételhez kötjük a futtatást.
            /////Felépítése:
            /////while(feltétel) 
            /////{
            /////ciklusmag
            /////}

            ////1
            //Console.Write("Kérem adjon meg egy számot: ");
            //int beSzam = int.Parse(Console.ReadLine());

            ////for (int i = 0; i < beSzam; i++) 
            ////{
            ////    //Console.WriteLine(i);
            ////}

            ////1b páros számok

            //for (int i = 0; i < beSzam; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            ////2
            //Console.Write("Kérem adjon meg egy jelszót: ");
            //string jelszo = Console.ReadLine();
            //string jelszo2 = "";
            //while(jelszo != jelszo2)
            //{
            //    Console.Write("Kérem ismételje meg a jelszót: ");
            //    jelszo2 = Console.ReadLine();

            //    if(jelszo != jelszo2)
            //    {
            //        Console.Clear();
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Hibás jelszót adtál meg!");
            //    } else
            //    {
            //        Console.Clear();
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine("A jelszó egyezik");
            //    }

            //    Console.ResetColor();
            //}

            ////3
            //Console.Write("Kérem adjon meg egy számot 1 és 1000 között: ");
            //int szam = int.Parse(Console.ReadLine());

            //Random random = new Random();
            //int randomSzam = random.Next(1, 1000);
            //int szamlalo = 0;

            //while (randomSzam != szam)
            //{
            //    randomSzam = random.Next(1, 1000);

            //    if (randomSzam != szam)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine(randomSzam);
            //        szamlalo++;
            //    }

            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //    }
            //    szamlalo++;
            //}

            //Console.WriteLine($"A szám egyezik: {randomSzam}\nPróbálkozások száma: {szamlalo}");
            //Console.ResetColor();


            ////4
            //Console.Write("Üdvözlöm a KockaPóker2000 játékban, kérem adja meg a játékosok számát: ");
            //int gamers = int.Parse(Console.ReadLine());

            //Random random = new Random();
            //int dobas = 0;
            //int i = 1;
            //int korokSzama = 1;

            //while (dobas != 6) 
            //{
            //    if (i == gamers + 1)
            //    {
            //        i = 1;
            //        korokSzama++;
            //    }

            //    Console.WriteLine($"Dobás következik, dobó játékos: Player{i}");
            //    Console.WriteLine("Készen áll a dobásra? (ENTER)");
            //    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            //    if (consoleKeyInfo.Key == ConsoleKey.Enter)
            //    {
            //        Console.WriteLine("Dobás...");
            //        dobas = random.Next(1, 7);
            //        Console.WriteLine($"Dobott szám: {dobas}");

            //        if (dobas < 6) 
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("A dobott szám kisebb mint 6");
            //        } 

            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine($"GYŐZELEM!!!\nA győztes: Player{i}\nDobott szám: 6\nKörök száma: {korokSzama}");
            //        }

            //        Console.ResetColor();
            //    }

            //    i++;
            //    Console.WriteLine("");
            //}

            ////5
            //Console.Write("Gondoltam egy számra... (Kérem adjon meg egy számot (felső határ: 1000)): ");
            //int bekertSzam = int.Parse(Console.ReadLine());
            //int futasiSzamlalo = 0;

            //Console.WriteLine("A program most addig fog elkérni számokat, míg az 'ki nem találja' a 'gondolt számot'.");
            //Random random = new Random();

            //int gondoltSzam = random.Next(0, 1001);

            //do
            //{

            //    if (gondoltSzam > bekertSzam)
            //    {
            //        Console.WriteLine($"({gondoltSzam}) -> A megadott szám nagyobb mint a 'gondolt számt'.");
            //        gondoltSzam = random.Next(0, gondoltSzam);

            //    }

            //    else if (gondoltSzam < bekertSzam)
            //    {
            //        Console.WriteLine($"({gondoltSzam}) -> A megadott szám kisebb mint a 'gondolt számt'.");
            //        gondoltSzam = random.Next(gondoltSzam + 1, 1001);
            //    }

            //    futasiSzamlalo++;

            //} while (gondoltSzam != bekertSzam);

            //if (gondoltSzam == bekertSzam)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Találat!!!");
            //    Console.WriteLine($"A kód ({futasiSzamlalo}) próbálkozás után találta ki a számot.");
            //    Console.ResetColor();
            //}

            ////6
            //Console.Write("Kérem adjon meg egy számot: ");
            //int bemenetiSzam = int.Parse(Console.ReadLine());

            //if (bemenetiSzam % 2 == 0)
            //{
            //    Console.WriteLine("A szám páros");
            //} else
            //{
            //    Console.WriteLine("A szám páratlan");
            //}

            //int db = 0;
            //for (int i = 2; i < bemenetiSzam; i++)
            //{
            //    if (bemenetiSzam % i == 0)
            //    {
            //        db++;
            //    }
            //}

            //Console.WriteLine($"({bemenetiSzam}) -> Valódi osztóinak száma: {db}");

            //if (db == 0)
            //{
            //    Console.WriteLine("A szám prímszám.");
            //} else
            //{
            //    Console.WriteLine("A szám nem prímszám.");
            //}

            ////7
            //Console.WriteLine("FAKTORIÁLIS KALKULÁTOR");
            //Console.Write("Kérem adjon meg egy pozitív egész számot: ");
            //int bekertSzam = int.Parse(Console.ReadLine());

            //int faktorialis = 1;

            //for (int i = 2; i <= bekertSzam; i++)
            //{
            //    faktorialis = faktorialis * i;
            //}

            //Console.WriteLine($"A ({bekertSzam}) faktoriálisa: {faktorialis}");

            ////8 FORMÁZOTT
            //int szamlalo = 0;
            //for (int i = 1; i <= 9; i++)
            //{
            //    if (i == 1)
            //    {
            //        for (int j = 1; j <= 9; j++)
            //        {
            //            if (j == 1)
            //            {
            //                Console.Write("\t");
            //            }
            //            Console.Write(j+"\t");
            //        }
            //        Console.WriteLine("\r\n");
            //    }
            //    for (int j = i; j <= 9 * i; j = j + i)
            //    {
            //        if (j == i)
            //        {
            //            Console.Write(j+"\t");
            //        }
            //        Console.Write(j+"\t");
            //    }
            //    Console.WriteLine("");
            //}

            ////8 VANILLA
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = i; j <= 9 * i; j = j + i)
            //    {
            //        Console.Write(j + "\t");
            //    }
            //    Console.WriteLine("");
            //}

            ////9
            //Console.Write("Kérem adjon meg MÁSODPERCBEN egy időtartamot: ");
            //int masodpercBekert = int.Parse(Console.ReadLine());

            //while(masodpercBekert > 0)
            //{
            //    int perc = masodpercBekert / 60;
            //    int masodperc = masodpercBekert % 60;

            //    Console.WriteLine($"{perc:D2}:{masodperc:D2}");

            //    System.Threading.Thread.Sleep(1000);
            //    masodpercBekert--;
            //    Console.Clear();
            //}
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("LEJÁRT AZ IDŐ");

            //Console.ResetColor();

            ////10
            //string binearis = "00000000000000000000000000000000";
            //string atvaltott = "";
            //Console.Write("Kérem adjon meg egy decimális (10-es számrendszerbeli) számot: ");
            //int bemenet = int.Parse(Console.ReadLine());
            //int bemenetTarolo = bemenet;
            //while (bemenet > 0)
            //{
            //    if (bemenet % 2 == 0)
            //    {
            //        bemenet = bemenet / 2;
            //        atvaltott += "0";
            //    }

            //    else
            //    {
            //        bemenet = bemenet / 2;
            //        atvaltott += "1";
            //    }
            //}

            //binearis = binearis.Substring(0, binearis.Length - atvaltott.Length);

            //for (int i = atvaltott.Length-1; i >= 0; i--)
            //{
            //    binearis += atvaltott[i];
            //}

            //Console.Write($"{bemenetTarolo} (10) = ");

            //int szamlalo = 0;
            //for (int i = 0; i < binearis.Length; i++)
            //{
            //    if (szamlalo != 8)
            //    {
            //        Console.Write(binearis[i]);
            //    } else
            //    {
            //        Console.Write(" ");
            //        szamlalo = 0;
            //    }
            //    szamlalo++;
            //}
            //Console.Write(" (2)");

            ////11
            //int kezdoKredit = 100;

            //bool vege = false;
            //int szamjegy1 = 0;
            //int szamjegy2 = 0;
            //int szamjegy3 = 0;
            //Random random = new Random();
            //int tet = 1;
            //Console.WriteLine("Üdvözöllek a FÉLKARÚRABLO2000 nevű játékban!\n");
            //while (!vege)
            //{
            //    if (kezdoKredit <= 0)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("----VÉGE A JÁTÉKNAK----");
            //        Console.WriteLine("Elfogyott a kredited.");
            //        vege = true;
            //    }

            //    else
            //    {
            //        Console.WriteLine("----ADATOK----");
            //        Console.WriteLine($"Rendelkezésre álló kredit: {kezdoKredit}");
            //        Console.WriteLine($"Kezdő téted: {tet}");
            //        Console.WriteLine("Tét növelése / csökkentése: Felfele / Lefele nyíl segítségével történhet");
            //        Console.WriteLine("Játék kezdése SPACEBAR lenyomásával történik");
            //        Console.WriteLine("Kilépés a játékból ESCAPE gomb segítégével lehet");
            //        ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            //        if (consoleKeyInfo.Key == ConsoleKey.UpArrow || consoleKeyInfo.Key == ConsoleKey.DownArrow)
            //        {

            //            if (consoleKeyInfo.Key == ConsoleKey.UpArrow)
            //            {
            //                if (tet + 5 <= kezdoKredit)
            //                {
            //                    tet = tet + 5;
            //                }

            //                else if (tet + 5 > kezdoKredit)
            //                {
            //                    tet = kezdoKredit;
            //                }
            //            }

            //            else if (consoleKeyInfo.Key == ConsoleKey.DownArrow)
            //            {
            //                if (tet - 5 >= 0)
            //                {
            //                    tet = tet - 5;
            //                } 

            //                else if (tet - 5 < 0)
            //                {
            //                    tet = tet - tet;
            //                }
            //            }
            //            Console.Clear();
            //        }

            //        else if (consoleKeyInfo.Key == ConsoleKey.Escape)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("----VÉGE A JÁTÉKNAK----");
            //            Console.WriteLine("Elfogyott a kredited.");
            //            vege = true;
            //        }

            //        else if (consoleKeyInfo.Key == ConsoleKey.Spacebar)
            //        {
            //            Console.Clear();
            //            Console.WriteLine($"Megtett tét: {tet}");
            //            kezdoKredit = kezdoKredit - tet;
            //            Console.WriteLine($"Jelenlegi egyenleged: {kezdoKredit}");
            //            Console.WriteLine();
            //            Console.WriteLine("----GENERÁLT SZÁMOK----");
            //            szamjegy1 = random.Next(0, 10);
            //            szamjegy2 = random.Next(0, 10);
            //            szamjegy3 = random.Next(0, 10);

            //            Console.WriteLine($"Első szám: {szamjegy1}");
            //            Console.WriteLine($"Második szám: {szamjegy2}");
            //            Console.WriteLine($"Harmadik szám: {szamjegy3}");
            //            Console.WriteLine("");
            //            if (szamjegy1 == szamjegy2 && szamjegy1 == szamjegy3)
            //            {
            //                tet = tet * 50;
            //                kezdoKredit = kezdoKredit + tet;
            //                Console.WriteLine();
            //                Console.WriteLine("----GYŐZELEM----");
            //                Console.WriteLine($"50x győzelem: {tet}");
            //                Console.WriteLine($"Egyenleged: {kezdoKredit}");
            //                System.Threading.Thread.Sleep(5000);
            //            }

            //            else if (szamjegy1 == szamjegy2 || szamjegy1 == szamjegy3 || szamjegy2 == szamjegy3)
            //            {
            //                tet = tet * 10;
            //                kezdoKredit = kezdoKredit + tet;
            //                Console.WriteLine("----GYŐZELEM----");
            //                Console.WriteLine($"10x győzelem: {tet}");
            //                Console.WriteLine($"Egyenleged: {kezdoKredit}");
            //                System.Threading.Thread.Sleep(5000);
            //                Console.WriteLine();
            //            }

            //            else
            //            {
            //                Console.WriteLine("----VESZTETTÉL----");
            //                Console.WriteLine($"Elvesztett összeg: {tet}");
            //                Console.WriteLine($"Egyenleged: {kezdoKredit}");
            //                System.Threading.Thread.Sleep(5000);
            //                Console.WriteLine();
            //            }

            //            tet = 1;
            //        }

            //        else
            //        {
            //            Console.Clear();
            //        }
            //    }
            //}

            ////13
            //double Pt = 52; //aktualis arfolyam mondjuk 52$

            //double r = 1.01; //1%-os növekedésről beszélünk most
            ////Ha r az kisebb mint 1 akkor csökken az árfolyam, ha nagyobb akkor nő az árfolyam

            //double N = 10; //elkövetkezendő 5 órában akarjuk megnézni a változást

            //int alfa = 3;

            //Random random = new Random();

            //for (int t = 0; t < N; t++)
            //{
            //    double epsilon = random.Next((alfa * -1), alfa); 
            //    //valós szám, ami a -alfa és az alfa között kerül kisorsolásra. Árfolyam befolyásolására szolgál.

            //    Pt = r * Pt + epsilon; //Kiszámoljuk a meglévő adatokkal a következő árfolyam értékét

            //    Console.WriteLine($"A 't+1'. órában az árfolyam: {Pt:F2}"); //:F2 ugyanolyan mint korábban vett D2 forma, csak a tizedes jegyeket mutatja, hogy 
            //    //mennyit jelenítsen meg, jelen esetben 2 tizedesjegy pontossággal jelenítjük meg az értéket.
            //}
        }
    }
}