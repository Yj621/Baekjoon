using System.Text;

namespace Baekjoon_10798
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[5];
            int maxLength = 0;
            for (int i = 0; i<5; i++)
            {
                array[i] = Console.ReadLine();
                if (array[i].Length > maxLength)
                {
                    maxLength = array[i].Length;
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < maxLength; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i < array[j].Length)
                    {
                        sb.Append(array[j][i]);
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
