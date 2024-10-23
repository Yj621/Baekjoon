using System;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            int temp = 0;
            string[] nm = Console.ReadLine().Split();
            N = int.Parse(nm[0]);
            M = int.Parse(nm[1]);

            int[] numbers = new int[N];

            for (int j = 0; j < N; j++)
            {
                numbers[j] = j + 1;
            }
            for (int i = 0; i < M; i++)
            {
                string[] input = Console.ReadLine().Split();

                int a, b;
                a = int.Parse(input[0]);
                b = int.Parse(input[1]);

                temp = numbers[a - 1];
                numbers[a - 1] = numbers[b - 1];
                numbers[b - 1] = temp;

            }
            for (int j = 0; j < N; j++)
            {
                Console.Write(numbers[j] + " ");
            }
        }
    }
}