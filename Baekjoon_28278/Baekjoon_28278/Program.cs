using System;
using System.Text;

namespace Baekjoon_28278
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            Stack<int> stack = new Stack<int>();

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();
                int command = int.Parse(input[0]);

                switch (command)
                {
                    case 1:
                        int value = int.Parse(input[1]);
                        stack.Push(value);
                        break;
                    case 2:
                        if (stack.Count == 0)
                        {
                            sb.AppendLine("-1");
                        }
                        else
                        {
                            sb.AppendLine(stack.Pop().ToString());
                        }
                        break;
                    case 3:
                        sb.AppendLine(stack.Count.ToString());
                        break;
                    case 4:
                        if(stack.Count == 0)
                        {
                            sb.AppendLine("1");
                        }
                        else
                        {
                            sb.AppendLine("0");
                        }
                        break;
                    case 5:
                        if(stack.Count == 0)
                        {
                            sb.AppendLine("-1");
                        }
                        else
                        {
                            int top = stack.Peek();
                            sb.AppendLine(top.ToString());
                        }
                        
                        break;
                }
            }
            Console.Write(sb.ToString());
        }
    }
}
