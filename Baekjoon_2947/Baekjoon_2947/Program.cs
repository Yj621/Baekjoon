namespace Baekjoon_2947
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int[] input = new int[5];

            for (int i = 0; i < 5; i++)
            {
                input[i] = Convert.ToInt32(inputs[i]);
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                        Console.WriteLine(string.Join(" ", input));
                    }
                }
            }
        }
    }
}
