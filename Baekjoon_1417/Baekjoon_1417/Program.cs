using System.Text;

namespace Baekjoon_1417
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine());
            int dasom = int.Parse(sr.ReadLine());

            int[] candidate = new int[N];
            int count = 0;

            bool isBig = false;


            for (int i = 0; i < N - 1; i++)
            {
                candidate[i] = int.Parse(sr.ReadLine());
            }

            while (!isBig)
            {
                isBig = true;
                Array.Sort(candidate);
                Array.Reverse(candidate);
                if (dasom <= candidate[0])
                {
                    isBig = false;
                    candidate[0]--;
                    dasom++;
                    count++;
                }
            }
            sw.WriteLine(count);

            sw.Close();
            sr.Close();
        }

    }
}