
namespace Domino_hazi_1
{
    internal class PMPHF015_A29A8O
    {
        static void Main(string[] args)
        {

            //1 ≤N ≤100
            //0 ≤A, B ≤6

            int N = int.Parse(Console.ReadLine());
            List<string> dominok = new List<string>();

            for (int i = 0; i < N; i++)
            {
             
                string domino = Console.ReadLine();
                dominok.Add(domino);

            }

            foreach (string domino in dominok)
            {
                Console.WriteLine(domino);
            }
        }
    }
}
