using System.Numerics;
using System.Runtime.InteropServices;

namespace Baekjoon_31430
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tInput = Console.ReadLine();
            if (string.IsNullOrEmpty(tInput)) return;
            int T = int.Parse(tInput);

            if (T == 1)
            {
                string[] input = Console.ReadLine().Split();
                long A = long.Parse(input[0]);
                long B = long.Parse(input[1]);
                long sum = A + B;

                for (int i = 0; i < 13; i++)
                {
                    // 26으로 나눈 나머지를 구함(숫자 -> 알파벳 변환)
                    // 거기에 a를 더하면 0이면 a, 1이면 b, 25면 z가 됨
                    Console.Write((char)(sum % 26 + 'a'));
                    // 사용한 자릿수는 버리고 다음 자릿수로 넘어감
                    sum /= 26;
                }
                Console.WriteLine(); // 출력을 깔끔하게 마무리
            }
            else
            {
                // 알파벳 -> 숫자
                string s = Console.ReadLine();
                if (string.IsNullOrEmpty(s)) return;
                long sum = 0, power = 1;

                for (int i = 0; i < 13; i++)
                {
                    // 알파벳에서 a를 빼서 원래 숫자로 복구
                    // 그 숫자에서 가중치를 곱함
                    sum += (long)(s[i] - 'a') * power;
                    power *= 26;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
