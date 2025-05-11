using System;

class Program
{
    static int memo;
    static void Main()
    {
        int[] dp = new int[12];
        dp[1] = 1;
        dp[2] = 2;
        dp[3] = 4;

        int T = int.Parse(Console.ReadLine()); //테스트케이스 수
        int[] testCase = new int[T];

        for (int i = 0; i < T; i++)
        {
            testCase[i] = int.Parse(Console.ReadLine());
        }

        for(int i =4; i<=11; i++)
        {
            dp[i] = dp[i-1] + dp[i-2] + dp[i-3];
        }

        for(int i=0; i<T; i++)
        {
            Console.WriteLine(dp[testCase[i]]);
        }
    }
}
