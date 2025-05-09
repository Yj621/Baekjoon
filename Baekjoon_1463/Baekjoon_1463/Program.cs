namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            // 1로 만드는 최소 연산 횟수
            int[] dp = new int[N + 1];

            for(int i = 2; i<=N;i++)
            {
                //1빼기 했을때 최소 횟수 +1
                dp[i] = dp[i - 1] + 1;

                //3으로 나눌때 최소 횟수 +1
                if (i % 3 == 0)
                {
                    dp[i] = Math.Min(dp[i], dp[i / 3] + 1);
                }

                //2으로 나눌때 최소 횟수 +1
                if (i % 2 == 0)
                {
                    dp[i] = Math.Min(dp[i], dp[i / 2] + 1);
                }
            }
            Console.WriteLine(dp[N]);
        }

    }
}