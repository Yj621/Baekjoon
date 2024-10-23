using System.Text;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();

            int N = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                bool isClosed = true;

                stack.Clear();

                foreach(char c in input)
                {
                    if(c == '(')
                    {
                        stack.Push(c);
                    }
                    else if(c == ')')
                    {
                        if(stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        else
                        {
                            isClosed = false;
                            break;
                        }
                    }
                }
                if(isClosed && stack.Count == 0)
                {
                   Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}