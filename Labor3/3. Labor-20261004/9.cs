/*

Debug C# code using Visual Studio:
    - https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-debugger?view=vs-2022

Az alábbi algoritmussal szeretnénk az x tömb elemeit fordított sorrendben megkapni. Használjuk a hibakereső
üzemmódot a hibák felderítésére és javítására.

int[] x = { 1, 2, 3, 4, 5, 6, 7, 8};
for (int i = 0; i < x.Length; i++)
{
    int tmp = x[i];
    x[i] = x[x.Length – i – 1];
    x[x.Length - i] = tmp;
}
_______________

Hiba 1: Indexelési hiba
    Az utolsó elem cseréjénél az indexelés hibás.
    Az x[x.Length - i] kifejezés helyett x[x.Length - i - 1] kellene.

Hiba 2: Ciklus tartománya
    A ciklusnak csak a tömb feléig kell futnia, mert minden egyes cserélés két elemet érint.
    Más szóval a tömb felénél a jobbról-balról cserélés össze fog érni.
    Így a ciklusnak a x.Length / 2-ig kell futnia.

A helyes kimenet:
    A tömb fordított sorrendben:
    8 7 6 5 4 3 2 1 

Hibakeresési javaslatok:
    Futtatás: A programot hibakereső üzemmódban futtatva,
              lépésről lépésre követheted a ciklus végrehajtását és megfigyelheted,
              hogyan változnak az elemek a cserék során.

    Megfigyelés: Ellenőrizd a tmp változó értékét és az x tömb elemeit a ciklus minden lépése során,
                 hogy biztosan látható legyen a működés folyamata.
*/

// A javított kód

int[] x = { 1, 2, 3, 4, 5, 6, 7, 8 };

// A for ciklus i < x.Length / 2-ig fut, így csak az első felét iterálja a tömbnek.
for (int i = 0; i < x.Length / 2; i++)
{
    int tmp = x[i];
    x[i] = x[x.Length - i - 1];
    // A cserélés során a x[x.Length - i - 1] indexet használjuk, hogy a megfelelő elemeket tudjuk cserélni.
    x[x.Length - i - 1] = tmp;
}

// Eredmény kiírása
Console.WriteLine("A tömb fordított sorrendben:");
foreach (int elem in x)
{
    Console.Write(elem + " ");
}