namespace Baekjoon_2738
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);        
            int M = int.Parse(input[1]);
            Add(N, M);
        }
        public static void Add(int N, int M)
        {
            int[,] matrixA = new int[N, M];
            int[,] matrixB = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < M; j++)
                {
                    matrixA[i, j] = int.Parse(row[j]);
                }
            }
            for (int i = 0; i < N; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < M; j++)
                {
                    matrixB[i, j] = int.Parse(row[j]);
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(matrixA[i, j] + matrixB[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
