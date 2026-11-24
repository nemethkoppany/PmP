using System.Security.Cryptography.X509Certificates;

namespace NemethKoppanyZoltan_A29A8O_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("kerekpar_berlesek.txt");
        
            List<Kerekparberles> berlesek = new List<Kerekparberles>(); 
            for(int i = 1;i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(";");
                Kerekparberles k = new Kerekparberles();
                k.azonosito = parts[0];
                k.Hetfo_berles = float.Parse(parts[1]);
                k.Kedd_berles = float.Parse(parts[2]);
                k.Szerda_berles = float.Parse(parts[3]);
                k.Csut_berles = float.Parse(parts[4]);
                k.Pentek_berles = float.Parse(parts[5]);

                berlesek.Add(k);
                
            }

            //2. feladat
            foreach (Kerekparberles k in berlesek)
            {
                Console.WriteLine($"{k.azonosito}: {(k.Hetfo_berles + k.Kedd_berles + k.Szerda_berles + k.Csut_berles + k.Pentek_berles)/5:F2}");
            }


            //4. feladat
            List<float> atlagok = new List<float>();    

            foreach (Kerekparberles k in berlesek)
            {
                atlagok.Add((k.Hetfo_berles + k.Kedd_berles + k.Szerda_berles + k.Csut_berles + k.Pentek_berles) / 5);
            }

            float legkisebb = atlagok[0];
            float legnagyobb = atlagok[0];
            

            for (int i = 0; i < berlesek.Count; i++)
            {
                foreach (float k in atlagok)
                {
                    if (k < legkisebb)
                    {
                        legkisebb = k;
                        Kerekparberles kis_azon = berlesek[0];
                    }
                    if (k > legnagyobb)
                    {
                        legnagyobb = k;
                        Kerekparberles nagy_azon = berlesek[0];
                    }
                }
            }
            

            Console.WriteLine($"A legkisebb átlag a {legkisebb:F2} és a legnagyobb a {legnagyobb:F2}");
            //Console.WriteLine($"A legkisebb átlag a {legkisebb:F2} és azonosítója: {kis_azon}");

            //List<string> list = new List<string>();
            //3.
            Console.Write("");
            foreach(Kerekparberles a in berlesek)
            {
                if((a.Hetfo_berles + a.Kedd_berles + a.Szerda_berles+a.Csut_berles+a.Pentek_berles)/5 > 20.2)
                {
                    //list.Add(a.azonosito);
                    Console.Write($"{a.azonosito}, ");
                }
            }
            Console.Write("rendelkezik 20,2 feletti átlagos napi bérlésszámmal.");

           

        }


    }
    class Kerekparberles{
        public string azonosito;
        public float Hetfo_berles;
        public float Kedd_berles;
        public float Szerda_berles;
        public float Csut_berles;
        public float Pentek_berles;
    }
}
