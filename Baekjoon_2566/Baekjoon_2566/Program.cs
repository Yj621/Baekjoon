namespace Baekjoon_2566
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[9, 9];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(input[j]);
                }
            }

            int maxV = 0;
            int maxRow = 0;
            int maxCol = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i, j] > maxV)
                    {
                        maxV = array[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }
            Console.WriteLine(maxV);
            Console.WriteLine($"{maxRow+1} {maxCol+1}");
        }
    }
}
