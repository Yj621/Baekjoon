using System;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n+1];
            input[0] = 0;
            input[1] = 1;
            for (int i=2; i<= n ; i++)
            {
                input[i] = input[i - 1] + input[i-2];
            }

            Console.WriteLine(input[input.Length - 1]);
        }
    }
}