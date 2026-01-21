namespace Baekjoon_1699
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dp = new int[n + 1];

            for(int i = 0; i<=n; i++)
            {
                dp[i] = i;

                for(int j = 1; j*j <= i; j++)
                {
                    if (dp[i] > dp[i-j *j] +1 )
                    {
                        dp[i] = dp[i-j *j]+1;
                    }
                }
            }
            Console.WriteLine(dp[n]);
        }
    }
}
