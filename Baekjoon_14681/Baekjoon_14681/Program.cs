using System;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a > 0 && b > 0)
            {
                Console.WriteLine("1");
            }
            else if (a < 0 && b > 0)
            {
                Console.WriteLine("2");
            }
            else if (a < 0 && b < 0)
            {
                Console.WriteLine("3");
            }
            else if (a > 0 && b < 0)
            {
                Console.WriteLine("4");
            }
        }
    }
}