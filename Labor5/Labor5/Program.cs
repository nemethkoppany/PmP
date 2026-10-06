using System;

namespace Labor5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
<<<<<<< HEAD
            //4 feladat van összesen
            Console.WriteLine("Hello World!");
=======
            //string filename = "1.txt";

            //if (!File.Exists(filename))
            //{
            //    Console.WriteLine("Ez a fájl nem létezik");
            //    return;
            //}

            //string[] lines = File.ReadAllLines(filename);

            //foreach (string line  in lines)
            //{
            //    string[] parts = line.Split("#", 2);

            //    if (parts.Length == 2)
            //    {
            //        string colorName = parts[0].Trim();
            //        string text = parts[1].Trim();

            //        if(colorName.ToLower() == "red")
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //        }
            //        else if(colorName.ToLower() == "blue")
            //        {
            //            Console.ForegroundColor = ConsoleColor.Blue;
            //        }
            //        else if (colorName.ToLower() == "green")
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"A '{colorName}'-re nincs beállított szín. alap fehér lesz");
            //            Console.ForegroundColor = ConsoleColor.White;
            //        }

            //        Console.WriteLine(text);
            //        Console.ResetColor();
            //    }
            //}
            //-----------------------------------------------------------------------------------------------------------------

            //2.
            //Random rnd = new Random();


            //DateTime datum = DateTime.Now;
            //string answer;

            //do
            //{
            //    List<int> otLottoSzam = new List<int>();
            //    while (otLottoSzam.Count < 5)
            //    {
            //        int szam = rnd.Next(1, 91);
            //        bool benneVan = false;
            //        for (int i = 0; i < otLottoSzam.Count; i++)
            //        {
            //            if (otLottoSzam[i] == szam)
            //            {
            //                benneVan = true;
            //            }
            //        }

            //        if (!benneVan)
            //        {
            //            otLottoSzam.Add(szam);
            //        }
            //    }


            //    string szamokSzoveg = string.Join(" ", otLottoSzam);
            //    string kimenet = $"On {datum:yyy:MM:dd} numbers were {szamokSzoveg}";

            //    Console.WriteLine(kimenet);
            //    File.AppendAllText("log.txt", kimenet);

            //    datum = datum.AddDays(7);

            //    Console.Write("Another week? [y/n]");
            //    answer = Console.ReadLine();
            //}
            //while (answer == "y");
            //-----------------------------------------------------------------------------------------------------------------

            //3.
            //string[] lines = File.ReadAllLines("2.txt");

            //    string[] firstLine = lines[0].Split(" ");
            //    double x = double.Parse(firstLine[0]);
            //    double y = double.Parse(firstLine[1]);
            //    double fok = double.Parse(firstLine[2]);

            //    Console.WriteLine($"Kezdő pozíció: X = {x}, Y = {y}, Irány = {fok}°");


            //for (int i = 1; i < lines.Length; i++)
            //{
            //    string[] tobbiSor = lines[i].Split(" ");
            //    string parancsok = tobbiSor[0];
            //    double ertek = double.Parse(tobbiSor[1]);

            //    if(parancsok == "left")
            //    {
            //        fok = (fok - ertek) % 360;
            //        if (fok < 0) fok += 360;
            //    }
            //    else if(parancsok == "right")
            //    {
            //        fok = (fok + ertek) % 360;
            //    }
            //    else if(parancsok == "go")
            //    {
            //        if(fok == 0 || fok == 360)
            //        {
            //            y += ertek;
            //        }
            //        else if(fok == 90)
            //        {
            //            x += ertek;
            //        }
            //        else if(fok == 180)
            //        {
            //            y -= ertek;
            //        }
            //        else if(fok == 270)
            //        {
            //            x -= ertek;
            //        }
            //    }

            //}
            //Console.WriteLine($"Végső pozíció: x = {x} y = {y} fok = {fok}");



            //-----------------------------------------------------------------------------------------------------------------

            //4.

            //string file = "NHANES_1999-2018.csv";

            //string[] lines = File.ReadAllLines(file);

            //int adatsorokSzama = lines.Length-1;

            //int[] seqn = new int[adatsorokSzama];
            //string[] survey = new string[adatsorokSzama];
            //int[] riagendr = new int[adatsorokSzama];
            //int[] ridageyr = new int[adatsorokSzama];
            //double[] bmxbmi = new double[adatsorokSzama];
            //double[] lbdglusi = new double[adatsorokSzama];

            //for(int i = 1; i < lines.Length; i++)
            //{
            //    string[] parts = lines[i].Split(",");
            //    int tombIndex = i - 1;

            //    seqn[tombIndex] = int.Parse(parts[0]);
            //    survey[tombIndex] = parts[1];
            //    riagendr[tombIndex] = int.Parse(parts[2]);
            //    ridageyr[tombIndex] = int.Parse(parts[3]);
            //    bmxbmi[tombIndex] = double.Parse(parts[4]);
            //    lbdglusi[tombIndex] = double.Parse(parts[5]);
            //}
            //Console.WriteLine($"Sikeresen beolvasva {adatsorokSzama} alany adatai!");

            ////4-1
            ////Console.Write("Adja meg a keresett felmérést (pl. 2017-2018): ");
            ////string keresettSurvey = Console.ReadLine();

            ////double ferfiBMI = 0;
            ////int ferfiDB = 0;

            ////double noBMI = 0;
            ////int noDB = 0;

            ////for(int i = 0; i < adatsorokSzama; i++)
            ////{
            ////    if(survey[i] == keresettSurvey)
            ////    {
            ////        if(riagendr[i] == 1)
            ////        {
            ////            ferfiBMI += bmxbmi[i];
            ////            ferfiDB++;
            ////        }
            ////        else if (riagendr[i] == 2)
            ////        {
            ////            noBMI += bmxbmi[i];
            ////            noDB++;
            ////        }
            ////    }
            ////}

            ////if(ferfiDB > 0)
            ////{
            ////    double ferfiAtlagBMI = ferfiBMI / ferfiDB;
            ////    Console.WriteLine($"Férfi BMI index átlag: {Math.Round(ferfiAtlagBMI,2)}");
            ////}
            ////if (noDB > 0)
            ////{
            ////    double NoAtlagBMI = noBMI/ noDB;
            ////    Console.WriteLine($"Férfi BMI index átlag: {Math.Round(NoAtlagBMI, 2)}");
            ////}

            ////4-2
            ////Console.Write("Adja meg a keresett felmérést (pl. 2017-2018): ");
            ////string keresettSurvey = Console.ReadLine();
            ////int adottSurveynAlanyok = 0;

            ////double magasvercukorSzint = 0;

            ////for(int i = 0; i < adatsorokSzama; i++)
            ////{
            ////    if(survey[i] == keresettSurvey)
            ////    {
            ////        adottSurveynAlanyok++;
            ////        if (lbdglusi[i] > 5.6)
            ////        {
            ////            magasvercukorSzint++;
            ////        }
            ////    }
            ////}

            ////if (adottSurveynAlanyok > 0)
            ////{
            ////    double szazalek = (double)magasvercukorSzint / adottSurveynAlanyok * 100;
            ////    Console.WriteLine($"Az adott időszakban az alanyok {szazalek} százaléka rendelkezik magas vércukorral.");

            ////}

            ////4-3
            ////double maxBMI = 0;
            ////double verCukor = 0;

            ////for(int i = 0; i < adatsorokSzama; i++)
            ////{
            ////    if (bmxbmi[i] > maxBMI)
            ////    {
            ////        maxBMI = bmxbmi[i];
            ////        verCukor = lbdglusi[i];
            ////    }


            ////}
            ////    Console.WriteLine($"A max BMI-s alany vércukra {verCukor}");

            ////4-4
            ////int tulsulyos_db = 0;
            ////int tulsuly_eletkor = 0;

            ////for(int i = 0;i < adatsorokSzama;i++)
            ////{
            ////    if(bmxbmi[i] >= 30)
            ////    {
            ////        tulsulyos_db++;
            ////        tulsuly_eletkor += ridageyr[i];
            ////    }
            ////}
            ////double atlag = (double)tulsuly_eletkor / (double)tulsulyos_db;
            ////Console.WriteLine($"A túlsúlyos emberek átlag életkora: {atlag:F2}");
>>>>>>> eb54c9f58e4622625264b1ab383409f27c13e62c
        }
    }
}
