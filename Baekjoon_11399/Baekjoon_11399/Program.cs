namespace Baekjoon_11399
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] time = new int[N];

            Array.Sort(arr);

            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += arr[i];
                time[i] = sum;
            }
            Console.WriteLine(time.Sum());
        }
    }
}
