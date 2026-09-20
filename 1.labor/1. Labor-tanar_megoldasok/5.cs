/*
Készítsünk programot, amely elkéri a felhasználó testmagasságát (h, méterben) és testtömegét (m, kilo-
grammban), majd kiszámítja és kiírja a felhasználó testtömegindexét (BMI). A számításhoz használt formula:

BMI = m / h^2
*/

// Felhasználó testmagasságának bekérése méterben (A nem egész számot pontal (.) szeparaljuk [Nem vesszővel!])
Console.Write("Kérlek, add meg a testmagasságodat méterben (pl. 1.75): ");
double magassag = double.Parse(Console.ReadLine());

// Felhasználó testtömegének bekérése kilogrammban
Console.Write("Kérlek, add meg a testsúlyodat kilogrammban: ");
double tomeg = double.Parse(Console.ReadLine());

// BMI kiszámítása (BMI = m / h^2)
double bmi = tomeg / (magassag * magassag);

// A BMI kiírása két tizedesjegyre formázva (változó:F2).
Console.WriteLine($"A testtömegindexed (BMI) értéke: {bmi:F2}");

// Program vége
Console.WriteLine("Nyomj meg egy Enter billentyűt a kilépéshez...");
Console.ReadLine();