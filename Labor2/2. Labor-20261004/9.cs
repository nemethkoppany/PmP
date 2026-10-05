/*
Készítsünk időzítő alkalmazást, amely elkér egy másodpercben megadott időtartamot, majd kiírja azt a
képernyőre perc:másodperc formátumban, és visszaszámlálást indít. Minden eltelt másodperc után törölje a
képernyőt, és írja ki a még hátralévő időt. A visszaszámlálást végét jelezze a képernyő pirosra váltásával és
sípolással.

A késleltetéshez használjuk a System.Threading.Thread.Sleep(1000); utasítást.
*/

Console.Write("Add meg az időtartamot másodpercben: ");
int duration = int.Parse(Console.ReadLine());

// Visszaszámlálás indítása (Ha elértük a nullát a ciklus befejeződik)
while (duration > 0)
{
    // Képernyő törlése
    Console.Clear();

    /*
    // Idő formátumra hozása
    TimeSpan time = TimeSpan.FromSeconds(duration);
    Console.WriteLine($"{time.Minutes:D2}:{time.Seconds:D2}");
    */

    Console.WriteLine($"Hatralevő idő: {duration / 60:D2}:{duration % 60:D2}");

    // óra:perc:másodperc formátumban
    // Console.WriteLine($"Hatralevő idő: {duration/3600:D2}:{(duration%3600)/60:D2}:{duration%60:D2}");

    // Egy másodperc várakozás
    Thread.Sleep(1000);

    // Csökkentjük a hátralévő időt
    duration--;
}

// Visszaszámlálás vége
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red; // Piros szöveg
Console.WriteLine("Vége!");
Console.Beep(); // Sípolás

// Visszaállítjuk a szöveg színét az alapértelmezettre
Console.ResetColor();