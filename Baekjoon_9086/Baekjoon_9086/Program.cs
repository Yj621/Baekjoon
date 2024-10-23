using System;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string input = Console.ReadLine();
                Console.WriteLine(input[0].ToString() + input[input.Length-1].ToString());
            }
        }
    }
}