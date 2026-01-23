using System.Numerics;

namespace Baekjoon_31836
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> groupA = new List<int>();
            List<int> groupB = new List<int>();

            //가장 큰 번호부터 거꾸로 검사
            int i = n;

            // 남은 숫자가 3개 이상일때까지 반속
            while(i >= 3)
            {
                groupA.Add(i); //A에는 가장 큰 수
                groupB.Add(i - 1); //B에는 그 다음 큰수
                groupB.Add(i - 2); //B에는 또 그 다음 큰수

                i -= 3;// 3개를 처리했으니 다음 번호로 넘어감
            }
            if(i==2)
            {
                groupA.Add(1);
                groupB.Add(2);
            }
            Console.WriteLine(groupA.Count);
            Console.WriteLine(string.Join(" ", groupA));
                
            Console.WriteLine(groupB.Count);
            Console.WriteLine(string.Join(" ", groupB));
        }
    }
}
