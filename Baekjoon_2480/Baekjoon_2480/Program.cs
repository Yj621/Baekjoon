using System;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            if (a == b && b ==c)
            {
                Console.WriteLine(10000 + (a * 1000));
            }
            else if(a == b)
            {
                Console.WriteLine(1000 + (a * 100));
            }
            else if (a == c)
            {
                Console.WriteLine(1000 + (a * 100));
            }
            else if (b == c)
            {
                Console.WriteLine(1000 + (b * 100));
            }
            else
            {
                if(a > b && a > c)
                {
                    Console.WriteLine(a * 100);
                }
                else if(b > c)
                {
                    Console.WriteLine(b * 100);
                }
                else
                {
                    Console.WriteLine(c * 100);
                }
            }
        }
    }
}