namespace Baekjoon_2941
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] alphet = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };

            var word = Console.ReadLine();

            foreach (string s in alphet)
            {
                word = word.Replace(s, "*");
            }
            Console.WriteLine(word.Length);
        }
    }
}
