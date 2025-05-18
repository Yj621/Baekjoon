namespace Baekjoon_9465
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            while(T > 0)
            {
                int N = int.Parse(Console.ReadLine());

                //첫째줄 입력
                string[] str0 = Console.ReadLine().Split();
                //둘째줄 입력
                string[] str1 = Console.ReadLine().Split();

                // 실제 점수를 숫자로 저장할 배열
                long[,] arr = new long[2, N +1];

                long[,] dp = new long[2, N + 1];

                //입력 받은ㅇ 점수 arr에 넣기
                for (int i = 1; i <= str0.Length; i++)
                {
                    arr[0, i] = long.Parse(str0[i - 1]);
                    arr[1, i] = long.Parse(str1[i - 1]);
                }

                dp[0, 1] = arr[0,1]; //위쪽만 뗐을때
                dp[1, 1] = arr[1,1]; //아래만 똈을때

                for(int i = 2; i <= N; i++)
                { 
                    // 위쪽 스티커를 i번째 칸에서 떼려면,
                    // i-1칸에서 아래쪽을 떼었을 때 OR i-2칸에서 아래쪽을 떼었을 때 중 큰 곳에서 시작
                    dp[0, i] = Math.Max(dp[1, i - 1], dp[1, i - 2]) + arr[0, i];
                    //아래 스티커 "
                    dp[1, i] = Math.Max(dp[0, i - 1], dp[0, i - 2]) + arr[1, i];
                }

                // 마지막 칸에서 위쪽/아래쪽 중 더 높은 점수가 답
                Console.WriteLine(Math.Max(dp[0,N], dp[1,N]));
                T--;
            }
        }
    }
}
