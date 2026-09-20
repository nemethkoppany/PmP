namespace Labor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            //Console.WriteLine("Hello, World!");

            //2.
            //Console.WindowHeight = 10;
            //Console.WindowWidth = 10;
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.SetCursorPosition(0, 0);
            //Console.CursorVisible = false;
            //Console.Clear();

            //3.
            //Console.WriteLine("Add meg a neved");
            //string nev = Console.ReadLine();
            //Console.WriteLine($"Üdv, {nev}!");

            //4.
            //Console.WriteLine("Add meg, hogy mikor születtél: ");
            //int eletkor_ev = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Te most {DateTime.Now.Year-eletkor_ev} éves vagy és egy év múlva {DateTime.Now.Year - eletkor_ev+1} éves leszel");

            //5.
            //Console.WriteLine("Add meg a magasságod méterben (pl.: 1.75): ");
            //double magassag = double.Parse(Console.ReadLine());

            //Console.WriteLine("Add meg a súlyodat kilogrammban (pl.:75): ");
            //double suly = double.Parse(Console.ReadLine());

            //double bmi = suly / (magassag * magassag);

            //Console.WriteLine($"A te testtömeg indexed {bmi:F2}");

            //6.
            //Console.WriteLine("Adj meg egy időtartamot másodpercben");

            //int mp = int.Parse(Console.ReadLine());

            //int perc = mp / 60;
            //int kiszamolt_mp = mp % 60;

            //Console.WriteLine($"{perc}:{kiszamolt_mp:D2}");

            //7.
            // Console.WriteLine("Add meg a jelszavad");
            // string jelszo = Console.ReadLine();

            // Console.WriteLine("Add meg megint a jelszavad");
            // string megerositett_jelszo = Console.ReadLine();

            // if(jelszo == megerositett_jelszo)
            // {
            //     Console.ForegroundColor = ConsoleColor.Green;
            //     Console.WriteLine("Szuper vagy! :D");
            // }
            // else
            // {
            //     Console.ForegroundColor= ConsoleColor.Red;
            //     Console.WriteLine("nem jó :(");
            // }
            //Console.ResetColor();

            //8.
            Console.WriteLine("Add meg a jelszavad");
            string jelszo = Console.ReadLine();

            Console.WriteLine("Add meg megint a jelszavad");
            string megerositett_jelszo = Console.ReadLine();

            if (jelszo == megerositett_jelszo)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Szuper vagy! :D");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("nem jó :(");
            }
            Console.ResetColor();

        }
    }
}
