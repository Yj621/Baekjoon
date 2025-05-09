namespace Baekjoon_10809
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < 26; i++)
            {
                Console.Write(input.IndexOf((char)(97 + i)));

                Console.Write(' ');
            }
        }
    }
}
