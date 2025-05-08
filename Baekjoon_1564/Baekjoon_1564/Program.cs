using System;
using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(sr.ReadLine());

            int last5 = Factorial(n);
            sw.WriteLine(last5.ToString("D5"));

            sw.Close();
            sr.Close();
        }

        static int Factorial(int num)
        {
            BigInteger acc = 1;
            BigInteger MOD = 1000000000000;

            for (int i = 1; i <= num; i++)
            {
                acc *= i;

                //끝자리가 0이면 계속 나눠줌
                while (acc % 10 == 0)
                {
                    acc /= 10;
                }
                acc %= MOD;
            }
            return (int)(acc % 100000);//마지막 5자리 남기기
        }
    }
}
