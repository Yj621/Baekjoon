using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon_10867
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N=int.Parse(Console.ReadLine());
            List<int> list = new List<int>();   

            string[]  input = Console.ReadLine().Split(); 
            for(int i= 0; i<N; i++)
            {
                list.Add(int.Parse(input[i]));
            }
            int[] result = list.Distinct().ToArray();

            Array.Sort(result);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}