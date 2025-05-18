namespace Baekjoon_1157
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            int max = 0;

            int[] freq = new int[26];

            //A~Z 각각 빈도 체크
            foreach (char c in input)
            {
                if (c >= 'A' && c <= 'Z')
                    freq[c - 'A']++;
            }

            //최댓값 찾기
            max = freq.Max();

            if (freq.Count(x => x == max) > 1)
            {
                Console.WriteLine("?"); 
            }
            else
            {
                char result = (char)(Array.IndexOf(freq, max) + 'A');
                Console.WriteLine(result);
            }

        }
    }
}
