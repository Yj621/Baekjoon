using System.Linq;

namespace Baekjoon_1431
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] serials = new string[N];
            for (int i = 0; i < N; i++)
            {
                serials[i] = Console.ReadLine();
            }
            Array.Sort(serials, (a, b) =>
            {
                if (a.Length != b.Length)
                    return a.Length.CompareTo(b.Length);

                int sumA = GetSum(a);
                int sumB = GetSum(b);
                if (sumA != sumB)
                    return sumA.CompareTo(sumB);

                return string.Compare(a, b);
            });
            foreach (var s in serials)
            {
                Console.WriteLine(s);
            }
        }
        static int GetSum(string s)
        {
            int sum = 0;
            foreach (char c in s)
            {
                if(char.IsDigit(c))
                {
                    sum += c - '0';
                }
            }
            return sum;
        }
    }
}
