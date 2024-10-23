using System.Runtime.Intrinsics.Arm;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] dp = new int[N + 1]; //1로 가는 최소 연산 횟수

            dp[1] = 0; //1로 가는 건 0임

            for (int i = 2; i <= N; i++)
            {
                dp[i] = dp[i - 1] + 1;
                if (i % 2 == 0)
                {
                    Console.WriteLine("dp1 : " + dp[i]);
                    dp[i] = Math.Min(dp[i], dp[i / 2] + 1);
                    Console.WriteLine("dp2 : " + dp[i]);
                }
                if (i % 3 == 0)
                {
                    dp[i] = Math.Min(dp[i], dp[i / 3] + 1);
                }
            }

            Console.WriteLine(dp[N]);
        }


    }
}