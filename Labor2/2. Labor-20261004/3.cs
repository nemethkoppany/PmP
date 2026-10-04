/*
Írjunk programot, amely addig generál véletlen számokat
1 és 1000 között, amíg az meg nem egyezik a
program kezdetén a felhasználó által megadott számmal.
Számoljuk meg, hány próbálkozás kellett a találathoz.
*/

// https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0
Random random = new Random();

Console.Write("Add meg a keresett számot (1 és 1000 között): ");
int targetNumber = int.Parse(Console.ReadLine());

if (targetNumber < 1 || targetNumber > 1000)
{
    Console.WriteLine("A számnak 1 és 1000 között kell lennie.");
    return;
}

int attempts = 0;
int generatedNumber;

do
{
    generatedNumber = random.Next(1, 1001);
    attempts++;
}
while (generatedNumber != targetNumber);

Console.WriteLine($"A keresett szám {targetNumber} volt.");
Console.WriteLine($"Próbálkozások száma: {attempts}");
