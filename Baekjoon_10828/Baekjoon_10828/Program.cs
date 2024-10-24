using System.Text;

namespace Baekjoon_10828
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Stack<int> stack = new Stack<int>();

            int N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++) 
            {
                string[] input = Console.ReadLine().Split();
                string fun =input[0];

                switch(fun)
                {
                    case "push":
                        int value = int.Parse(input[1]); 
                        stack.Push(value);
                        break;

                    case "pop":
                        if(stack.Count == 0)
                        {
                            sb.AppendLine("-1");
                        }
                        else
                        {
                            sb.AppendLine(stack.Pop().ToString());
                        }
                        break;

                    case "size":
                        sb.AppendLine(stack.Count().ToString());
                        break;

                    case "empty":
                        if(stack.Count() == 0)
                        {
                            sb.AppendLine("1");
                        }
                        else
                        {
                            sb.AppendLine("0");
                        }
                        break;

                    case "top":
                        if(stack.Count ==0)
                        {
                            sb.AppendLine("-1");
                        }
                        else
                        {
                            sb.AppendLine(stack.Peek().ToString());
                        }
                        break;

                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}