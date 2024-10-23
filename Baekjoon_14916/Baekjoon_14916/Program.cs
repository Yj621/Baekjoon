namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int count = 0;
            while (N >= 0)
            {
                if(N % 5 ==0)
                {
                    count += N / 5;
                    Console.WriteLine(count);
                    return;
                }

                N -= 2;
                count++;
            }
            Console.WriteLine(-1); 

        }
    }

}
