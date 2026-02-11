namespace Baekjoon_1965
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            // Array.ConvertAll(변환할 배열, 변환할 형식)
            int[] box = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] dp = new int[N];

            for (int i = 0; i < N; i++)
            {
                dp[i] = 1;
                for(int j = 0; j<i; j++)
                {
                    if (box[j] < box[i])
                    {
                        // Math.Max(a, b) a, b 중 최대값 리턴
                        dp[i]=Math.Max(dp[i], dp[j]+1);
                    }
                }
            }
            Console.WriteLine(dp.Max());
        }
    }
}
