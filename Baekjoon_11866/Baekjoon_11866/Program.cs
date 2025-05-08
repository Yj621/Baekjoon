namespace Baekjoon_11866
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            List<int> list = new List<int>();
            List<int> result = new List<int>();

            for (int i = 1; i <= N; i++)
            {
                list.Add(i);
            }
            int index = 0;

            while(list.Count>0)
            {
                index = (index + K - 1) % list.Count;
                
                result.Add(list[index]);
                list.RemoveAt(index);
            }
            Console.Write("<");
            Console.Write(string.Join(", ", result));
            Console.Write(">");
        }
    }
}
