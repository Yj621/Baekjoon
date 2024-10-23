using System.Text;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Deque<int> qeque = new Deque<int>;
            int N =int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                string fun = Console.ReadLine();
                string[] parts = fun.Split(' ');

                if ((parts[0] == "push_front" || parts[0] == "push_back") && parts.Length == 2)
                {
                    int value;
                    if (int.TryParse(parts[1], out value)
                    {
                        Deque
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
