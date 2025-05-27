namespace Baekjoon_2225
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int N = input[0];
            int K = input[1];

            //K개의 수로 합이 N이 되는 경우의 수
            int[,] dp = new int[K + 1, N + 1];

            //0이 되는 경우의 수는 무조건 1임
            for (int i = 1; i <= K; i++)
            {
                dp[i, 0] = 1;
            }

            //첫번째 숫자를 0으로 고른것과 1로 고른 경우의 수를 더함
            for (int i = 1; i <= K; i++)
            {
                for(int j = 1; j <= N; j++)
                {
                    dp[i, j] = (dp[i - 1, j] + dp[i, j - 1]) % 1000000000;
                }
            }
            Console.WriteLine(dp[K,N] % 1000000000);
        }
    }
}
