namespace Baekjoon_19954
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int low = 1;
            int high = N;
            int answer = 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                Console.WriteLine("? " + mid);
                Console.Out.Flush(); // 버퍼 확실히 지우기

                // 서버 답변 읽ㄱ기
                int respone = int.Parse(Console.ReadLine());
                if (respone == 0)
                {
                    answer = mid;
                    break;
                }
                else if (respone == 1)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            Console.WriteLine("= " + answer);
            Console.Out.Flush();
        }
    }
}
