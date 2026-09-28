namespace Labor4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.
            //string szoveg = "Géza kék az ég";
            //string tiszta_szoveg = "";

            //foreach(char c in szoveg)
            //{
            //    if(char.IsDigit(c) || char.IsLetter(c))
            //    {
            //        tiszta_szoveg += char.ToLower(c);
            //    }
            //}

            //string viszaSzoveg = "";
            //for(int i = tiszta_szoveg.Length - 1; i >= 0; i--)
            //{
            //    viszaSzoveg += tiszta_szoveg[i];
            //}

            //if(tiszta_szoveg == viszaSzoveg)
            //{
            //    Console.WriteLine("A szöveg palindrom");
            //}
            //else
            //{
            //    Console.WriteLine("A szöveg nem palindrom");
            //}

            //3.
            //string rendszam = "aabc 123";

            //string betuk = "";
            //string szamok = "";

            //foreach (char c in rendszam)
            //{
            //    if (char.IsLetter(c))
            //    {
            //        betuk += char.ToUpper(c);
            //    }
            //    else if (char.IsDigit(c))
            //    {
            //        szamok += c;
                    
            //    }

            //    if(betuk.Length == 4 && szamok.Length == 3)
            //    {
            //        string formatRendszam = $"{betuk[0]}{betuk[1]}{betuk[2]}{betuk[3]}-{szamok}";
            //        Console.WriteLine($"A rendes formátumú rendszám: {formatRendszam}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("A rendszámba 4 betű és 3 szám kell");
            //    }
            //}

            //6.
            Random rnd = new Random();

            string neptunKOd = "asd123".ToUpper();

            int probalkozasok = 0;
            string generaltNeptunKod = "";

            do
            {
                char[] neptunKod = new char[6];
                string betuk = "ABCDEFGHIJKLMNOPQRSRUVWXYZ";
                string szamok = "0123456789";
                neptunKod[0] = betuk[rnd.Next(betuk.Length)];

                for(int i = 1; i < 6; i++)
                {
                    if(rnd.Next(2) == 0)
                    {
                        neptunKod[i] = betuk[rnd.Next(betuk.Length)];
                    }
                    else
                    {
                        neptunKod[i] = szamok[rnd.Next(szamok.Length)];
                    }
                }

                probalkozasok++;

                if (probalkozasok % 1000000 == 0)
                {
                    Console.WriteLine($"eddigi probálkozások: {probalkozasok}");
                }

               
            }
            while (generaltNeptunKod != neptunKOd);

            

        }
    }
}
