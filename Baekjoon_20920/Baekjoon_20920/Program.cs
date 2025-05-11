using System.Text;

namespace Baekjoon_20920
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            var freq = new Dictionary<string, int>();

            for(int i = 0; i<n;i++)
            {
                string word = Console.ReadLine();
                if (word.Length < m)
                    continue;
                if(freq.ContainsKey(word))
                    freq[word]++;
                else
                    freq[word] = 1;
            }
            var sorted = freq.Keys.OrderByDescending(w => freq[w]).ThenByDescending(w => w.Length).ThenBy(w => w);

            var sb = new StringBuilder();
            foreach (var w in sorted)
            {
                sb.AppendLine(w);
            }
            Console.Write(sb);
        }
    }
}
