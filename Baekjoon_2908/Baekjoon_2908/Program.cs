namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args) 
        {
            string input = Console.ReadLine();
            string[] array = input.Split(' ');

            char[] a = array[0].ToCharArray();
            char[] b = array[1].ToCharArray();

            Array.Reverse(a);
            Array.Reverse(b);

            int A = int.Parse(a);
            int B = int.Parse(b);
            if(A > B)
            {
                Console.WriteLine(A);
            }
            else
            {
                Console.WriteLine(B);
            }
        }
    }
}