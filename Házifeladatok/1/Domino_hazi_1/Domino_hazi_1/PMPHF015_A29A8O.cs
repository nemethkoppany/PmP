
namespace Domino_hazi_1
{
    internal class PMPHF015_A29A8O
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] fok = new int[7];
            bool[,] van = new bool[7, 7];


            for (int i = 0; i < N; i++)
            {
             
                string domino = Console.ReadLine();

                string[] domino_elemek = domino.Split("|");
                int a = int.Parse(domino_elemek[0]);
                int b = int.Parse(domino_elemek[1]);

                fok[a]++;
                fok[b]++;

                van[a,b] = true;
                van[b,a] = true;
            }

            int paratlanokDB = 0;
            for(int i = 0;i < fok.Length; i++)
            {
                if (fok[i] % 2 != 0)
                {
                    paratlanokDB++;
                }
            }

            bool[] meglatogatott = new bool[7];

            int kezdo = -1;

            for(int i = 0; i < 7; i++)
            {
                if(kezdo == -1 && fok[i] > 0)
                {
                    kezdo = i;
                }
            }
            meglatogatott[kezdo] = true;

            for(int kor = 0; kor < 7; kor++)
            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if(meglatogatott[i] && van[i, j])
                        {
                            meglatogatott[j] = true;
                        }
                    }
                }
            }

            bool osszefuggo = true;
            for (int i = 0; i < 7; i++)
            {
                if (fok[i] > 0 && !meglatogatott[i])
                {
                    osszefuggo = false;
                }
            }

            if((paratlanokDB == 0 || paratlanokDB == 2)&&osszefuggo)
            {
                Console.WriteLine("Y");
            }
            else
            {
                Console.WriteLine("N");
            }


        }
    }
}
