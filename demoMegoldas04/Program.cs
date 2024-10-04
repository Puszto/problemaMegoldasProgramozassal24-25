////1
//Console.Write("Kérem adjom meg egy szöveget: ");
//string bemenet = Console.ReadLine();

//int maganhanzo = 0;
//int betu = 0;
//int szamjegyek = 0;

//for (int i = 0; i < bemenet.Length; i++)
//{
//	char tmp = bemenet[i];

//    if (char.IsDigit(tmp))
//    {
//        szamjegyek++;
//    }

//    else if (char.IsLetter(tmp))
//    {
//        betu++;

//        if ("aáeéiíoóöőuúüű".Contains(tmp))
//        {
//            maganhanzo++;
//        }
//    }
//}

//Console.WriteLine($"Betűk: {betu}\nSzamjegyek: {szamjegyek}\nMagánhangzók: {maganhanzo}");


////2
//Console.Write("Kérem adjon meg egy szöveget: ");
//string bemenet = Console.ReadLine().Trim().ToLower().Replace(" ", "");

//string bemenetReverse = "";

//for (int i = bemenet.Length-1; i >= 0; i--)
//{
//    if (bemenet[i] != ' ')
//    {
//        bemenetReverse += bemenet[i];
//    }
//}

//if (bemenet == bemenetReverse)
//{
//    Console.WriteLine("Ez egy palindrom szöveg.");
//}

//else
//{
//    Console.WriteLine("Ez nem palindrom szöveg.");
//}

////3
//Console.Write("Kérem adjon meg egy szöveget: ");
//string bemenet = Console.ReadLine().Trim().Replace(" ", "").ToLower();

//int count = 0;

//string kimenet = "";

//for (int i = 0; i < bemenet.Length; i++)
//{
//    if ("aábcdeéfghiíjklmnoóöőpqrstuúüűvwxyz1234567890".Contains(bemenet[i]))
//    {
//        kimenet += bemenet[i];
//        count++;
//    }

//    if ((count) == 2)
//    {
//        kimenet += " ";
//    }

//    if((count) == 4)
//    {
//        kimenet = kimenet.ToUpper();
//        kimenet += "-";
//        count++;
//    }
//}

//Console.WriteLine(kimenet);

////4
//Random random = new Random();

//string kimenet = "";
//int count = 0;

//for (int i = 0; i < 7; i++)
//{
//    if (count < 2)
//    {
//        kimenet += (char)random.Next('A', 'Z' + 1);
//        count++;
//        if (count == 2)
//        {
//            kimenet += " ";
//        }
//    }

//    else if (count < 4)
//    {
//        kimenet += (char)random.Next('A', 'Z' + 1);
//        count++;
//        if (count == 4)
//        {
//            kimenet = kimenet.ToUpper();
//            kimenet += "-";
//        }
//    }

//    else
//    {
//        kimenet += random.Next(1, 10).ToString();
//    }
//}

//Console.WriteLine($"A random rendszámom: {kimenet}");


////5
//Console.Write("Kérem adjon meg egy email címet: ");
//string bemenet = Console.ReadLine();

////a
//int atcount = 0;

//for (int i = 0; i < bemenet.Length; i++)
//{
//    if (bemenet[i] == '@')
//    {
//        atcount++;
//    }
//}

//bool atcountThem = atcount == 1; //a
//bool atbefore = false; //b
//bool atdotAfter = false; //c
//bool atbetweenDot = false; //d
//bool atdotbefore = true; //e
//bool lastDigitsLength = false; //f

//if (atcountThem)
//{
//    int atindexof = bemenet.IndexOf('@');

//    atbefore = bemenet.Substring(0, atindexof).Length > 0; //b
//    atdotAfter = bemenet.Substring(atindexof + 1).Contains("."); //c

//    int lastIndexOfDot = bemenet.LastIndexOf(".");
//    atbetweenDot = bemenet.Substring(atindexof, (lastIndexOfDot 
//        - atindexof)).Length > 0; //d

//    string atbeforeCheck = bemenet.Substring(0, atindexof);
//    if (atbeforeCheck.Contains(".") && atbeforeCheck.StartsWith
//        (".") || atbeforeCheck.EndsWith("."))
//    {
//        atdotbefore = false;
//    }

//    lastDigitsLength = bemenet.Substring((bemenet.LastIndexOf
//        (".") + 1)).Length >= 2; //f
//}

//if (atcountThem && atbefore && atdotAfter && atbetweenDot && 
//    atdotbefore && lastDigitsLength)
//{
//    Console.WriteLine("A megadott email megfelelt az " +
//        "elvárásoknak.");
//}

//else
//{
//    Console.WriteLine("A megadott email nem felelt meg az " +
//        "elvárásoknak.");
//}


////6
//Console.Write("Kérem adjon meg egy Neptun kódot: ");
//string bemenet = Console.ReadLine();
//Random random = new Random();

//string neptun = "";
//int counter = 0;

//int proba = 0;
//bool talalat = false;

//while(!talalat)
//{
//	proba++;

//	if (counter == 0)
//	{
//		neptun += (char)random.Next('A', 'Z' + 1);
//	}
//	else if (counter < 6)
//	{
//		int szamOrBetu = random.Next(0, 2);

//		if (szamOrBetu == 0)
//		{
//            neptun += (char)random.Next('A', 'Z' + 1);
//        }

//		else
//		{
//			neptun += random.Next(0,10);
//		}
//    }

//	else if (counter == 6)
//	{
//		counter = -1;
//		if (neptun == bemenet)
//		{
//            talalat = true;
//			Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine($"{neptun}\nTALÁLAT! A NEPTUN KÓDOD: {neptun}, próbálkozások száma: {proba}");
//			Console.ResetColor();
//        }

//		else
//		{
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine(neptun);
//            Console.ResetColor();
//        }

//		neptun = "";
//	}
//	counter++;
//}

////7
//Console.Write("Kérem adjon meg egy szöveget: ");
//string bemenet = Console.ReadLine();
//Random rnd = new Random();
//string kimenet = "";

//for (int i = 0; i < bemenet.Length; i++)
//{
//    int tmp = rnd.Next(0,2);
//	if (tmp == 0)
//	{
//		kimenet += char.ToLower(bemenet[i]);
//	}

//	else
//	{
//        kimenet += char.ToUpper(bemenet[i]);
//    }
//}

//Console.WriteLine($"\n{bemenet}\n{kimenet}");


////8
//string bemenet = "Vincent;Vega;Vince\nMarsellus;Wallace;Big Man\nWinston;Wolf;The Wolf";
//int rows = bemenet.Split("\n").Length;
//int cols = bemenet.Split("\n")[0].Split(";").Length;

//string[,] tarolo = new string[rows, cols];

//for (int i = 0; i < rows; i++)
//{
//    string[] tmp = bemenet.Split("\n")[i].Split(";");
//    for (int j = 0; j < cols; j++)
//    {
//        tarolo[i, j] = tmp[j];
//    }
//}

//for (int i = 0; i < tarolo.GetLength(0); i++)
//{
//    for (int j = 0; j < tarolo.GetLength(1); j++)
//    {
//        Console.Write(tarolo[i,j]+" - ");
//    }
//    Console.WriteLine("");
//}

////9
//string bemenet = "[()][()()]()";

//Stack<char> nyito = new Stack<char>();

//bool helyes = true;
//char open = ' ';
//char close = ' ';

//if (string.IsNullOrEmpty(bemenet))
//{
//    helyes = false;
//}
//else
//{
//    for (int i = 0; i < bemenet.Length && helyes; i++)
//    {
//        if (bemenet[i] == '[' || bemenet[i] == '{' || bemenet[i] == '(')
//        {
//            nyito.Push(bemenet[i]);
//        }

//        else
//        {
//            if (nyito.Count == 0)
//            {
//                helyes = false;
//            }

//            else
//            {
//                open = nyito.Pop();
//                close = bemenet[i];

//                if (open == '[' && close != ']')
//                {
//                    helyes = false;
//                }

//                if (open == '{' && close != '}')
//                {
//                    helyes = false;
//                }

//                if (open == '(' && close != ')')
//                {
//                    helyes = false;
//                }
//            }
//        }
//    }
//}

//if (helyes && nyito.Count == 0)
//{
//    Console.WriteLine("Helyes a zárójelezés.");
//}

//else
//{
//    Console.WriteLine("Helytelen a zárójelezés.");
//}

////10
//char[,] tarolo = new char[20, 30];

//int row = 0;
//int col = 0;

//while (true)
//{
//    Console.Clear();
//    for (int i = 0; i < tarolo.GetLength(0); i++)
//    {
//        for (int j = 0; j < tarolo.GetLength(1); j++) Console.Write(tarolo[i, j]);

//        Console.WriteLine();
//    }

//    Console.SetCursorPosition(col, row);

//    ConsoleKeyInfo bemenet = Console.ReadKey();

//    if (bemenet.Key == ConsoleKey.Backspace)
//    {
//        if (col > 0)
//        {
//            col--;
//            tarolo[row, col] = ' ';
//        }
//        else if (col == 0 && row > 0)
//        {
//            row--;
//            col = tarolo.GetLength(1)-1;
//            tarolo[row, col] = ' ';
//        }
//    }

//    else if (bemenet.Key == ConsoleKey.UpArrow && row > 0) row--;

//    else if (bemenet.Key == ConsoleKey.DownArrow && tarolo.GetLength(0) > row) row++;

//    else if (bemenet.Key == ConsoleKey.LeftArrow && col > 0) col--;

//    else if (bemenet.Key == ConsoleKey.RightArrow && col < tarolo.GetLength(1)) col++;

//    else
//    {
//        tarolo[row, col] = bemenet.KeyChar;
//        col++;
//    }

//    if (col == tarolo.GetLength(1))
//    {
//        col = 0;
//        if (row < tarolo.GetLength(0)) row++;
//    }
//}


////11
//string szotar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

////teszt esetek pl.:
////Man
////abc
////hello
////Base64 encoding
//char[] bemenet = "Base64 encoding".ToCharArray();
//string bitek = "";

//for (int i = 0; i < bemenet.Length; i++)
//{
//    int bemenetChar = bemenet[i];
//    string tmp = "";

//    while (bemenetChar > 0)
//    {
//        if (bemenetChar % 2 == 0)
//        {
//            tmp += "0";
//        }
//        else
//        {
//            tmp += "1";
//        }
//        bemenetChar /= 2;
//    }

//    // Ha a bináris ábrázolás hossza kevesebb mint 8 bit, akkor kiegészítjük nullákkal
//    while (tmp.Length < 8)
//    {
//        tmp += "0";
//    }

//    // A karakterek bináris formátumát megfordítjuk, hogy helyes sorrendben legyenek
//    string tmp2 = "";
//    for (int j = tmp.Length - 1; j >= 0; j--)
//    {
//        tmp2 += tmp[j];
//    }

//    bitek += tmp2;
//}

//// A bitek hosszának 6-tal oszthatónak kell lennie, ha nem az, akkor kiegészítjük nullákkal
//while (bitek.Length % 6 != 0)
//{
//    bitek += "0";
//}

//int swiftedBitsSize = (int)Math.Ceiling((double)bitek.Length / 6);
//string[] swiftedBits = new string[swiftedBitsSize];

//string tarolo = "";
//int count = 0;
//for (int i = 0; i < bitek.Length; i++)
//{
//    tarolo += bitek[i];
//    if ((i + 1) % 6 == 0)
//    {
//        swiftedBits[count] = tarolo;
//        tarolo = "";
//        count++;
//    }
//}

//// Átalakítjuk a 6 bites csoportokat Base64 kódindexekké
//int[] kodolas = new int[swiftedBits.Length];
//for (int i = 0; i < swiftedBits.Length; i++)
//{
//    int summa = 0;
//    int power = 0;
//    for (int j = swiftedBits[i].Length - 1; j >= 0; j--)
//    {
//        if (swiftedBits[i][j] == '1')
//        {
//            summa += (int)Math.Pow(2, power);
//        }
//        power++;
//    }
//    kodolas[i] = summa;
//}

//// A kapott indexeket a szótár alapján kódoljuk
//string kodolt = "";
//for (int i = 0; i < kodolas.Length; i++)
//{
//    kodolt += szotar[kodolas[i]];
//}

//// Padding hozzáadása, ha a bemenet hossza nem osztható hárommal
//int paddingCount = (3 - (bemenet.Length % 3)) % 3;
//for (int i = 0; i < paddingCount; i++)
//{
//    kodolt += "=";
//}

//Console.WriteLine($"Átalakított kód: {kodolt}");