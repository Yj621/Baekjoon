namespace Baejoon_1138
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] order = new int[N];
            for (int i = 0; i < N; i++)
            {
                order[i] = int.Parse(input[i]);
            }
            List<int> result = new List<int>();

            //큰 사람부터 역순으로 
            for(int i = N; i>= 1; i--)
            {
                int pos = order[i - 1];
                result.Insert(pos, i);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
