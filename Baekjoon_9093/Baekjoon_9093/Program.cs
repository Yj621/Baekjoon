using System.Text;

namespace Baekjoon_9093
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < T; i++)
            {
                string input = Console.ReadLine();
                string[] words = input.Split(' ');

                StringBuilder result = new StringBuilder();

                foreach(string word in words)
                {
                    char[] chars = word.ToCharArray();
                    Array.Reverse(chars);
                    result.Append(new string(chars) + " ");
                }
                Console.WriteLine(result.ToString().Trim());
            }

        }
    }
}
