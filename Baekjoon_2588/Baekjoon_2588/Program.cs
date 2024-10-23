namespace Baekjoon
{ 
    class Program
    {
        static void Main(string[] args) 
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            int c, d, e, f;
            c = a * (b % 10);
            d = a * ((b % 100) - (b%10)) / 10;
            e = a * (b / 100);

            f = c +(d * 10) +(e * 100);

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
        }
    }

}
