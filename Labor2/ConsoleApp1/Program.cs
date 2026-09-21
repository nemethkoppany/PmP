using System.Security;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Kimaradt feladatok: 3,5,8,10,12,13

            //1.
            //Console.WriteLine("Adj meg egy egész számot");
            //int N = int.Parse( Console.ReadLine());

            //Console.WriteLine("számok 0 és a bekért szám között");
            //for (int i = 0; i <= N; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //1b.
            //Console.WriteLine("Adj meg egy egész számot");
            //int N = int.Parse(Console.ReadLine());

            //Console.WriteLine("A 0 és a bekért szám közötti páros számok");
            //for (int i = 0; i <= N; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //}

            //2.
            //Console.WriteLine("Adjuk meg a jelszót");
            //string storedPwsd = "Jelszo";
            //string inputPass = "";
            //do
            //{
            //    Console.Write($"Add meg a jelszót: ");
            //    inputPass = Console.ReadLine();
            //}
            //while (storedPwsd != inputPass);

            //Console.WriteLine("Sikerült kitalálni a jelszót");

            //2b
            //string storedPwsd = "Jelszo";
            //string inputPass = "";
            //int probalkozasok = 0;
            //do
            //{
            //    Console.Write($"Add meg a jelszót: ");
            //    inputPass = Console.ReadLine();
            //    probalkozasok++;

            //}
            //while (storedPwsd != inputPass && probalkozasok < 3);
            //if(probalkozasok == 3)
            //{
            //    Console.WriteLine("Nem sikerült kitalálni a jelszót");
            //}
            //else
            //{
            //    Console.WriteLine("Sikerült kitalálni a jelszót");
            //}

            //4.
            //Random random = new Random();

            //Console.WriteLine("Add meg a játékosok számát! ");
            //int playerINT = int.Parse(Console.ReadLine());

            //if(playerINT < 1 )
            //{
            //    Console.WriteLine("legalább egy játékosnak kell lennie");
            //    return;
            //}

            //int currentPlayer = 1;
            //bool isGameOn = true;

            //while (isGameOn)
            //{
            //    Console.WriteLine($"Játékos {currentPlayer}: Nyomd meg az Enter-t a dobáshoz");
            //    Console.ReadLine();

            //    int diceRoll = random.Next(1, 7);
            //    Console.WriteLine($"{currentPlayer} játékos {diceRoll}-t dobott");

            //    if(diceRoll == 6)
            //    {
            //        Console.WriteLine($"{currentPlayer} kezd!");
            //        isGameOn = false;
            //    }
            //    currentPlayer = currentPlayer % playerINT;
            //    currentPlayer++;
            //}

            //6.
            //Console.WriteLine("Adj meg egy pozitív egész számot!");
            //int N = int.Parse(Console.ReadLine());

            //if (N % 2 == 0)
            //{
            //    Console.WriteLine($"{N} páros");
            //}
            //else
            //{
            //    Console.WriteLine($"{N} páratlan");
            //}

            //int divisorcount = 0;
            //for (int i = 2; i < N; i++)
            //{
            //    if (N % i == 0)
            //    {
            //        divisorcount++;
            //    }
            //}
            //Console.WriteLine($"A szám pozitív valódi osztóinak száma: {divisorcount}");

            //bool isPrime = N > 1;
            //for(int i = 2; i <= Math.Sqrt(N); i++)
            //{
            //    if(N % i == 0)
            //    {
            //        isPrime = false;
            //        break;
            //    }
            //}
            //if (isPrime)
            //{
            //    Console.WriteLine($"{N} prím");
            //}
            //else
            //{
            //    Console.WriteLine($"{N} összetett szám");
            //}

            //7.(Valamiért kétszer kell beírni a számot)
            //Console.WriteLine("Adj meg egy pozitív egész számot!");
            //int N = int.Parse(Console.ReadLine());

            //if(!int.TryParse(Console.ReadLine(), out N) || N < 0)
            //{
            //    Console.WriteLine("érvényes számot adj meg");
            //    return;
            //}
            //long factorial = 1;
            //string factorialExpression = "";

            //for(int i = 1; i <= N; i++)
            //{
            //    factorial *= i;
            //    if(i > 1)
            //    {
            //        factorialExpression += "x";
            //    }
            //    factorialExpression += i.ToString();
            //}
            //Console.WriteLine($"{N}! = {factorialExpression} = {factorial}");


            //9.
            //Console.WriteLine("Add meg az időtartamot másodpercben");
            //int duration = int.Parse(Console.ReadLine());

            //while (duration > 0)
            //{
            //    Console.Clear();
            //    Console.WriteLine($"Hátralévő idő: {duration}");

            //    Thread.Sleep( 1000 );

            //    duration--;
            //}
            //Console.Clear() ;
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Vége!");
            ////Console.Beep();
            //Console.ResetColor();

            //11.
            int credits = 100;
            int bet = 1;
            Random random = new Random();
            ConsoleKey key;
            Console.WriteLine("Félkarú rabló");
            Console.WriteLine("Space: pörgetés, fel/le nyilak: tét növelés6csökkentés, Esc: kilépés");
            Console.WriteLine($"Elérhető kreditek: {credits}");
        }
    }
}
