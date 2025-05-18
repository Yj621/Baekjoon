using System.Text;

namespace Baekjoon_11866_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            Queue<int> queue = new Queue<int>();
            Queue<int> result = new Queue<int>();
            string[] input = sr.ReadLine().Split();

            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            for (int i = 1; i <= N; i++)
                queue.Enqueue(i);

            while (queue.Count > 0)
            {
                for (int i = 1; i < K; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                result.Enqueue(queue.Dequeue());
            }

            var sb = new StringBuilder();

            sb.Append("<");
            sb.Append(string.Join(", ",result));
            sb.Append(">");
            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}
