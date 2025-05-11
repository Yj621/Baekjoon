namespace Baekjoon_20364
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            string[] input = sr.ReadLine().Split();

            int N = int.Parse(input[0]);
            int Q = int.Parse(input[1]);
            bool[] occupy = new bool[N + 1];

            while (Q > 0)
            {
                Q -= 1;

                int x = int.Parse(sr.ReadLine());
                int blocked = 0;

                for (int i = x; i > 0; i /= 2)
                {
                    if (occupy[i])
                    {
                        blocked = i;
                    }
                }

                sw.WriteLine(blocked);
                if (blocked == 0)
                {
                    occupy[x] = true;
                }
            }
            sr.Close();
            sw.Close();
        }
    }
}
