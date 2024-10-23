namespace Baekjoon_10990
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
           for(int i = 1; i<=n-1; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
            for(int i = 2; i<= n-2; i++)
            {
                Console.Write('1');
            }
        }
    }
}