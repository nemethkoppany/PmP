/*
Bővítsük ki az előbbi programot: helyezzünk el néhányat az alábbi utasításokból a szöveg megjelenítését
végző utasítás elé vagy után. Az utasítások a kurzor és a parancssori ablak jellemzőit módosítják.
• Console.Clear()
• Console.WindowHeight
• Console.WindowWidth
• Console.BackgroundColor
• Console.ForegroundColor
• Console.SetCursorPosition()
• Console.CursorVisible
Hint: https://learn.microsoft.com/en-us/dotnet/api/system.consolecolor?view=net-8.0
*/

// Módosítjuk a konzolablak szélességét és magasságát
Console.WindowWidth = 60;
Console.WindowHeight = 20;

// A háttér- és előtérszín módosítása
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;

// A képernyő törlése a beállított színekkel
Console.Clear();
Console.ResetColor();
// A kurzor pozíciójának beállítása
Console.SetCursorPosition(10, 5);

// Szöveg megjelenítése a képernyőn
Console.WriteLine("Hello, World!");

// A kurzor elrejtése
Console.CursorVisible = false;

Console.WriteLine("Nyomj meg egy Enter billentyűt a kilépéshez...");
Console.ReadLine();

// A program végén visszaállítjuk a kurzort láthatóvá
Console.CursorVisible = true;