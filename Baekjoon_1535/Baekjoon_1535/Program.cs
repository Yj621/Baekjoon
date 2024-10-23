namespace Baekjoon_1535
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int maxHappy = 0;
            int[] HP = new int[N];
            int[] Happy = new int[N];



            string[] hpInput = Console.ReadLine().Split();
            for (int i = 0; i < N; i++)
            {
                HP[i] = int.Parse(hpInput[i]);
            }

            string[] happyInput = Console.ReadLine().Split();
            for (int j = 0; j < N; j++)
            {
                Happy[j] = int.Parse(happyInput[j]);
            }

            //2^N가지 경우의 수
            int pow = 1 << N;

            for (int k = 0; k < pow; k++)
            {
                int _Hp = 100;
                int _Happy = 0;

                for (int i = 0; i < N; i++)
                {
                    //i번째 사람을 선택했는지 확인(k의 i번째 비트가 1인지 확인)
                    if ((k & (1 << i)) != 0)
                    {
                        _Hp -= HP[i];
                        if (_Hp <= 0)
                            break;
                        _Happy += Happy[i];
                    }
                }
                if (_Hp > 0)
                {
                    maxHappy = Math.Max(maxHappy, _Happy);
                }
            }
            Console.WriteLine(maxHappy);

        }
    }
}
