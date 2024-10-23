using System;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string A = input[0];
            string B = input[1];
            int min = 50;

            for (int i = 0; i <= B.Length - A.Length ; i++)
            {
                int count = 0;
                for (int j= 0; j < A.Length ; j++)
                {
                    if (A[j] != B[i+j])
                    {
                        count++;
                    }
                }
                min = Math.Min(min, count);
            }
            Console.WriteLine(min);
        }
    }
}