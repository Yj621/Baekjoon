namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            int finalX = 0;
            int finalY = 0;

            int minX = 0;
            int minY = 0;
            int maxX = N+1;
            int maxY = N + 1;
            for (int m = 1; m <= M; m++)
            {
                string[] xyk = Console.ReadLine().Split();
                
                int x = int.Parse(xyk[0]);
                int y = int.Parse(xyk[1]);
                int k = int.Parse(xyk[2]);

                switch (k)
                {
                    case 1:
                        maxX = Math.Min(maxX, x);
                        finalY = y;
                        break;
                    case 2:
                        maxX = Math.Min(maxX, x);
                        minY = Math.Max(minY, y);
                        break;
                    case 3:
                        finalX = x;
                        minY = Math.Max(minY, y);
                        break;
                    case 4:
                        minX = Math.Max(minX, x);
                        minY = Math.Max(minY, y);
                        break;
                    case 5:
                        minX = Math.Max(minX, x);
                        finalY = y;
                        break;
                    case 6:
                        minX = Math.Max(minX, x);
                        maxY = Math.Min(maxY, y);
                        break;
                    case 7:
                        finalX = x;
                        maxY = Math.Min(maxY, y);
                        break;
                    case 8:
                        maxX = Math.Min(maxX, x);
                        maxY = Math.Min(maxY, y);
                        break;
                }

            }
            if (finalX == 0)
            {
                finalX = (minX + maxX) / 2;
            }
            if (finalY == 0)
            {
                finalY = (minY + maxY) / 2;
            }
            Console.WriteLine(finalX + " " + finalY);
        }
    }
}