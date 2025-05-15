using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon_10773
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Stack<int> K = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if(x == 0)
                {
                    K.Pop();
                }
                else
                {
                    K.Push(x);
                }
            }
            Console.WriteLine(K.Sum());
        }
    }
}
