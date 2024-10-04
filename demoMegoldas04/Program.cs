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
//string szam = "1234567890";
//string betuk = "aábcdeéfghiíjklmnoóöőpqrstuúüűvwxyz";

//Random random = new Random();

//string kimenet = "";
//int count = 0;

//for (int i = 0; i < 7; i++)
//{


//    if (count < 2)
//	{
//        kimenet += betuk[random.Next(0, betuk.Length)].ToString();
//        count++;
//        if (count == 2)
//        {
//            kimenet += " ";
//        }
//    }

//    else if (count < 4)
//    {
//        kimenet += betuk[random.Next(0, betuk.Length)].ToString();
//        count++;
//        if (count == 4)
//        {
//            kimenet = kimenet.ToUpper();
//            kimenet += "-";
//        }
//    }

//    else
//    {
//        kimenet += szam[random.Next(0, szam.Length)].ToString();
//    }
//}

//Console.WriteLine($"A random rendszámom: {kimenet}");


////5
//Console.Write("Kérem adjon meg egy email címet: ");
//string bemenet = Console.ReadLine();

////a
//int @count = 0;

//for (int i = 0; i < bemenet.Length; i++)
//{
//    if (bemenet[i] == '@')
//    {
//        @count++;
//    }
//}

//bool @countThem = @count == 1; //a
//bool @before = false; //b
//bool @dotAfter = false; //c
//bool @betweenDot = false; //d
//bool @dotbefore = true; //e
//bool lastDigitsLength = false; //f

//if (@countThem)
//{
//    int @indexof = bemenet.IndexOf('@');

//    @before = bemenet.Substring(0, @indexof).Length > 0; //b
//    @dotAfter = bemenet.Substring(@indexof + 1).Contains("."); //c

//    int lastIndexOfDot = bemenet.LastIndexOf(".");
//    @betweenDot = bemenet.Substring(@indexof, (lastIndexOfDot - @indexof)).Length > 0; //d

//    string @beforeCheck = bemenet.Substring(0, @indexof);
//    if (@beforeCheck.Contains(".") && @beforeCheck.StartsWith(".") || @beforeCheck.EndsWith("."))
//    {
//        @dotbefore = false;
//    }

//    lastDigitsLength = bemenet.Substring((bemenet.LastIndexOf(".") + 1)).Length >= 2; //f
//}

//if (@countThem && @before && @dotAfter && @betweenDot && @dotbefore && lastDigitsLength)
//{
//    Console.WriteLine("A megadott email megfelelt az elvárásoknak.");
//}

//else
//{
//    Console.WriteLine("A megadott email nem felelt meg az elvárásoknak.");
//}


////6
//int counter = 0;
//string karakterek = "aábcdeéfghiíjklmnoóöőpqrstuúüűvwxyz1234567890";
//Random randomChar = new Random();
//string neptunKod = "";

//while (counter < 6)
//{
//    if (counter == 0)
//    {
//        neptunKod += karakterek[randomChar.Next(karakterek.IndexOf("1"), karakterek.Length)];
//    }

//    else
//    {
//        neptunKod += karakterek[randomChar.Next(0, karakterek.Length)];
//    }

//    counter++;
//}

//Console.WriteLine($"Elkészült neptunkód: {neptunKod}");


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
//int rows = bemenet.Split("\n").Length-1;
//int cols = (bemenet.Split(";").Length - 1) / rows;

//string[,] tarolo = new string[rows + 1, cols];

//for (int i = 0; i < rows+1; i++)
//{
//	string[] tmp = bemenet.Split("\n");
//	for (int j = 0; j < cols; j++)
//	{
//		tarolo[i,j] = tmp[i].Split(";")[j];
//    }
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


////////EZ NINCS KÉSZ TELJESEN, SZÁMOKAT NEM JÓL KEZELI
////11
//string szotar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

//char[] bemenet = "64".ToCharArray();
//string bitek = "";

//for (int i = 0; i < bemenet.Length; i++)
//{
//    int bemenetChar = bemenet[i];
//    string tmp = "";

//    while (true)
//    {
//        if (bemenetChar % 2 == 0)
//        {
//            tmp += "0";
//            if (bemenetChar == 0)
//            {
//                break;
//            }
//        }

//        else if (bemenetChar % 2 != 0)
//        {
//            tmp += "1";
//        }

//        bemenetChar /= 2;
//    }

//    string tmp2 = "";

//    for (int j = tmp.Length - 1; j >= 0; j--)
//    {
//        tmp2 += tmp[j];
//    }

//    bitek += tmp2;
//}

//for (int i = 0; i < bitek.Length % 6; i++)
//{
//    bitek += "0";
//}

//int swiftedBitsSize = (int)Math.Ceiling((double)bitek.Length / 6);
//string[] swiftedBits = new string[swiftedBitsSize];

//string tarolo = "";
//int count = 0;
//for (int i = 0; i < bitek.Length; i++)
//{
//    if ((i + 1) % 6 == 0)
//    {
//        tarolo += bitek[i];
//        swiftedBits[count] = tarolo;
//        tarolo = "";
//        count++;
//    }

//    else
//    {
//        tarolo += bitek[i];
//    }
//}

//if (tarolo.Length != 0)
//{
//    swiftedBits[count] = tarolo;
//}

//int[] kodolas = new int[swiftedBits.Length];
//for (int i = 0; i < swiftedBits.Length; i++)
//{
//    int summa = 0;
//    int power = 0;
//    for (int j = swiftedBits[i].Length - 1; j >= 0; j--)
//    {
//        int tmp = 0;
//        if (swiftedBits[i][j] == '1')
//        {
//            summa += (int)Math.Pow(2, power);
//        }
//        summa += tmp;
//        power++;
//    }
//    kodolas[i] = summa;
//}

//string kodolt = "";

//for (int i = 0; i < kodolas.Length; i++)
//{
//    kodolt += szotar[kodolas[i]];
//}

//int paddingCount = 3 - (bemenet.Length % 3);
//if (paddingCount == 1)
//{
//    kodolt += "=";
//}
//else if (paddingCount == 2)
//{
//    kodolt += "==";
//}

//Console.WriteLine($"Átalakított kód: {kodolt}");

//;
