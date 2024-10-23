using System;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            string[] nm = Console.ReadLine().Split();
            N = int.Parse(nm[0]);
            M = int.Parse(nm[1]);

            int[] numbers = new int[N+1];

            for(int i=0; i<M; i++)
            {
                string[] input = Console.ReadLine().Split();

                int a, b, num;
                a = int.Parse(input[0]);
                b = int.Parse(input[1]);
                num = int.Parse(input[2]);

                for(int j=a; j<=b; j++)
                {
                    numbers[j] = num;
                }

            }
            for (int k = 1; k <= N; k++)
            {
                Console.Write(numbers[k] + " ");
            }

        }
    }
}