namespace Baekjoon_1449
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int L = int.Parse(input[1]);

            int[] pos = new int[N];
            string[] posInput = Console.ReadLine().Split();
            for (int i = 0; i < N; i++)
            {
                pos[i] = int.Parse(posInput[i]);
            }
            Array.Sort(pos);

            int count = 0;
            int tapeEnd = 0;
            foreach (int p in pos)
            {
                if (p > tapeEnd)
                {
                    count++;
                    tapeEnd = p + L - 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
