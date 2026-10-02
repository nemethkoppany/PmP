
namespace Domino_hazi_1
{
    internal class PMPHF015_A29A8O
    {
        static void Main(string[] args)
        {

            //1 ≤N ≤100
            //0 ≤A, B ≤6

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

            


        }
    }
}
