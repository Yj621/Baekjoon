using System;

class Program
{
    static int N;
    static int[,] triangle;
    static int[,] memo;
    static void Main()
    {
        N = int.Parse(Console.ReadLine());

        triangle = new int[N, N];
        memo = new int[N, N];

        //아직 계산하지 않은 값은 -1
        for(int i = 0; i<N; i++)
        {
            for(int j=0; j<N; j++)
            {
                memo[i, j] = -1;
            }
        }

        //삼각형 입력
        for (int i = 0; i < N; i++)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < parts.Length; j++)
            {
                triangle[i, j] = int.Parse(parts[j]);
            }
        }

        int sum = DFS(0, 0);
        Console.WriteLine(sum);
    }
    static int DFS(int row, int col)
    {
        if (row == N - 1)
        {
            return triangle[row, col];
        }
        if(memo[row, col] != -1)
        {
            return memo[row, col];
        }
        int down = DFS(row+1, col);
        int downRight = DFS(row+1, col+1);

        memo[row, col] = Math.Max(down, downRight) + triangle[row, col];
        return memo[row, col];
    }
}
