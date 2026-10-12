namespace Labor6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Book BookofAllBooks = new Book("The Hobbit","George R.R Tolkien", 1937,312);

            //2
            //Futo futo1 = new Futo("Alice", 0, 5);
            //Futo futo2 = new Futo("Bob", 1, 4);

            //int celvonal = 50;
            //int masodperc = 1;

            //while (futo1.GetDistance() < celvonal && futo2.GetDistance() < celvonal)
            //{
            //    Console.Clear();

            //    futo1.RefreshDistance(masodperc);
            //    futo2.RefreshDistance(masodperc);

            //    futo1.Show();
            //    futo2.Show();

            //    Thread.Sleep(1000);
            //}

            //Console.Clear();

            //if(futo1.GetDistance() >= celvonal)
            //{
            //    Console.WriteLine("Alice nyert");
            //}
            //else
            //{
            //    Console.WriteLine("Bob nyert");
            //}

        } 
    }

    //1
    //class Book
    //{
    //    private string Author;
    //    private string Title;
    //    private int Release_Date;
    //    private int Pagenumber;

    //    public Book(string author, string title, int release_Date, int pagenumber)
    //    {
    //        this.Author = author;
    //        this.Title = title;
    //        this.Release_Date = release_Date;
    //        this.Pagenumber = pagenumber;
    //    }

    //}

    //2
    //class Futo
    //{
    //    private string nev;
    //    private int sorszam;
    //    private double sebesseg;
    //    private double tavolsag;

    //    public Futo(string nev, int sorszam, double sebesseg)
    //    {
    //        this.nev = nev;
    //        this.sorszam = sorszam;
    //        this.sebesseg = sebesseg;
    //        tavolsag = 0;
    //    }

    //    public void RefreshDistance(int masodperc)
    //    {
    //        tavolsag += sebesseg * masodperc;
    //    }

    //    public void Show()
    //    {
    //        Console.SetCursorPosition((int)tavolsag, sorszam);
    //        Console.WriteLine(nev[0]);
    //        Console.SetCursorPosition(50, sorszam);
    //        Console.WriteLine("| Cél");
    //    }    

    //    public double GetDistance()
    //    {
    //        return tavolsag;
    //    }
    //}


}
