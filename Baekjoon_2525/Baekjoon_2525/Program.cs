using System;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int ovenMin = int.Parse(Console.ReadLine());

            int hour = int.Parse(input[0]);
            int min = int.Parse(input[1]);

            min += ovenMin;
            while(min >= 60)
            {
                hour++;
                min -= 60;
            }
            if(hour >= 24)
            {
                hour-=24;
            }
            Console.WriteLine(hour + " " + min);
        }
    }
}