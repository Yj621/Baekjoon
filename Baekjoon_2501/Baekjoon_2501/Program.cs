using System;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);
            //약수 넣을 곳
            List<int> q = new List<int>();


            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    q.Add(i);
                }
            }
            if(K <= q.Count)
            {
                Console.WriteLine(q[K - 1]);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}