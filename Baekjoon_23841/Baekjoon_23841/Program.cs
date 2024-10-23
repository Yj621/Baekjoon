namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]); // 가로
            int M = int.Parse(input[1]); // 세로

            string[,] decalcomanie = new string[N, M];

            for (int i = 0; i < N; i++)
            {
                string row = Console.ReadLine();  // 한 줄을 입력받음

                for (int j = 0; j < M; j++)
                {
                    decalcomanie[i, j] = row[j].ToString();  // 각 문자를 배열에 저장

                }
                for (int j = 0; j < M; j++)
                {
                    if (decalcomanie[i, j] != ".")
                    {
                        decalcomanie[i, M - j - 1] = decalcomanie[i, j];
                    }
                }

            }

            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < M; j++)
                {
                    Console.Write(decalcomanie[i, j]);
                }

                Console.WriteLine();  // 각 행을 출력 후 줄바꿈
            }
        }
    }
}
