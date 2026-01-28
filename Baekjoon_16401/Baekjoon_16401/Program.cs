namespace Baekjoon_16401
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int M = int.Parse(input[0]);
            int N = int.Parse(input[1]);

            int[] snackLengths = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Array.Sort(snackLengths);

            int low = 1;
            int high = snackLengths[snackLengths.Length -1];

            int result = 0;
            while(low<=high)
            {
                int mid = (low + high) / 2;
                long count = 0; //과자의 총 개수
                foreach (int snack in snackLengths)
                {
                    count += (snack / mid);
                }

                // 과자의 수 >= 조카의 수
                if (count >= M)
                {
                    result = mid;
                    low = mid + 1;
                }
                else
                {
                    high = mid -1;
                }
            }
            Console.WriteLine(result);
        }
    }
}
