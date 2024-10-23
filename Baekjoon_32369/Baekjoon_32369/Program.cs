using System;
using System.Diagnostics;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int N = int.Parse(input[0]);
            int A = int.Parse(input[1]);
            int B = int.Parse(input[2]);

            int goodOnion = 1;
            int badOnion = 1;
            for (int i = 1; i <= N; i++)
            {

                goodOnion += A;
                badOnion += B;
                if (goodOnion < badOnion)
                {
                    int tmp=0;
                    tmp = goodOnion;
                    goodOnion = badOnion;
                    badOnion = tmp;
                }
                else if(goodOnion == badOnion)
                {
                    badOnion -= 1;
                }
            }
            Console.WriteLine(goodOnion+" " + badOnion);
        }
    }
}