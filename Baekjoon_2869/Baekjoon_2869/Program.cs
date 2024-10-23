using System;

namespace Baekjoon_2869
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int V = int.Parse(input[2]);

            int day = (V - B - 1) / (A - B) +1 ;
            Console.WriteLine(day);
        }
    }
}
