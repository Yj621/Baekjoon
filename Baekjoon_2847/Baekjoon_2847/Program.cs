namespace Baekjoon_2847
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] level = new int[N];
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                level[i] = int.Parse(Console.ReadLine());
            }

            for (int i = N-2; i >=0 ; i--)
            {
                if (level[i] >= level[i + 1])
                {
                    int value = level[i + 1] - 1;
                    count += (level[i] - value);
                    level[i] = value;
                }
            }
            Console.WriteLine(count);
        }
    }
}
