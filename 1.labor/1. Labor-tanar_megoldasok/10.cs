/*
Alakítsuk át úgy az előző programot, hogy az képes legyen helyesen formázott matematikai kifejezések
kiértékelésére. Első lépésként valósítsuk meg, hogy a beolvasott szöveg alapján bármely kétoperandusú műveletet
(összeadás, kivonás, szorzás, osztás) el tudja végezni a program.
Példa
A kiszámítandó kifejezés: 18 / 3
Eredmény: 6
*/

using System;

class Program
{
    static void Main()
    {
        // Kifejezés bekérése
        Console.Write("A kiszámítandó kifejezés: ");
        string kifejezes = Console.ReadLine();

        try
        {
            // Kifejezés kiértékelése
            double eredmeny = EvaluateExpression(kifejezes);
            Console.WriteLine($"Eredmény: {eredmeny}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hiba: {ex.Message}");
        }

        // Program vége
        Console.WriteLine("Nyomj meg egy Enter billentyűt a kilépéshez...");
        Console.ReadLine();
    }

    // Egyszerű kifejezés kiértékelése
    static double EvaluateExpression(string expression)
    {
        var dataTable = new System.Data.DataTable();
        return Convert.ToDouble(dataTable.Compute(expression, string.Empty));
    }
}
