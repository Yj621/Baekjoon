namespace Baekjoon_11047
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string[] input = Console.ReadLine().Split();
                int N = int.Parse(input[0]);
                int K = int.Parse(input[1]);

                int[] money = new int[N];
                int cnt = 0;

                for (int i = 0; i < N; i++)
                {
                    money[i] = int.Parse(Console.ReadLine());
                }
                Array.Reverse(money);

                for (int i = 0; i < money.Length; i++)
                {
                    //동전이 K원보다 크면 넘어감
                    if (money[i] > K)
                    {
                        continue;
                    }

                    //K를 동전이랑 나누고
                    int num = K / money[i];
                    //나눈 나머지를 처리함
                    K %= money[i];
                    cnt += num;
                }
                Console.WriteLine(cnt);
            }
        }
    }
}
