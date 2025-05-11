namespace Baekjoon_1152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split();

            int result = 0;
            foreach (string inputs in input)
            {
                if (!string.IsNullOrEmpty(inputs))
                {
                    result++;
                }
            }
            Console.WriteLine(result);

        }
    }
}
