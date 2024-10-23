using System.Text;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n % 2 == 0)
            {
                Console.WriteLine("CY");
            }
            else
            {
                Console.WriteLine("SK");
            }
        }
    }
}