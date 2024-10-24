using System.Numerics;

namespace Baekjoon_10757
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            BigInteger A = BigInteger.Parse(input[0]);
            BigInteger B = BigInteger.Parse(input[1]);  

            Console.WriteLine(A + B);
        }
    }
}