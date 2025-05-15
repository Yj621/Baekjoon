namespace Baekjoon_2444
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());


            for(int i = 1; i<= N; i++)
            {
                Console.Write(new string(' ', N - i));
                Console.WriteLine(new string('*', 2*i - 1));
            }

            for (int i = N-1; i >=1; i--)
            {
                Console.Write(new string(' ', N - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
        }
    }
}
