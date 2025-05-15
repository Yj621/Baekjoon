namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> tall = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> rank = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            foreach(int idx in rank)
            {
                result.Add(tall[idx - 1]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
