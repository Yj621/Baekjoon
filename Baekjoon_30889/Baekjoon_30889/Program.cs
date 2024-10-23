using System;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            char[,] seats = new char[10, 20];
            for(int i = 0; i<10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    seats[i, j] = '.';
                }
            }

            for(int i = 0; i < N; i++)
            {
                string reserve = Console.ReadLine().Trim();
                int row = reserve[0] - 'A';
                int col = int.Parse(reserve.Substring(1))-1;
            }
        }
    }
}