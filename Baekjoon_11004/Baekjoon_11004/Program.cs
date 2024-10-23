namespace Baekjoon_11004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);
            int[] result = new int[N];

            string[] numbers = Console.ReadLine().Split();
            for (int i =0; i<N; i++)
            {
                result[i] = int.Parse(numbers[i]);
            }
            Array.Sort(result);
            Console.WriteLine(result[K-1]);
        }
    }
}