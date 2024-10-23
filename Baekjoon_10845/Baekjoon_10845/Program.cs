using System;
using System.Collections;
using System.Collections.Generic;

namespace BaekJoon
{
    class Program
    {
        static void Main()
        {
            Queue<int> queue = new Queue<int>();
            int N = int.Parse(Console.ReadLine());
            int num = 0;
            for (int i = 0; i < N; i++)
            {
                string fun = Console.ReadLine();
                string[] parts = fun.Split(' ');

                if (parts[0] == "push" && parts.Length == 2)
                {
                    int value;
                    if (int.TryParse(parts[1], out value))
                    {
                        queue.Enqueue(value);
                        num = value;
                    }
                }
                else if (parts.Length == 1)
                {
                    string command = parts[0];
                    if (command == "pop")
                    {
                        if(queue.Count == 0 )
                        {
                            Console.WriteLine(-1);
                        }
                        else
                        {
                            Console.WriteLine(queue.Dequeue());
                        }
                    }
                    else if (command == "size")
                    {
                        Console.WriteLine(queue.Count());   
                    }
                    else if (command == "empty")
                    {
                        if(queue.Count==0)
                        {
                            Console.WriteLine(1);
                        }
                        else
                        { Console.WriteLine(0); }
                    }
                    else if (command == "front")
                    {
                        if (queue.Count == 0)
                        {
                            Console.WriteLine(-1);
                        }
                        else
                        {
                            Console.WriteLine(queue.Peek());
                        }
                    }
                    else if (command == "back")
                    {
                        if (queue.Count == 0)
                        {
                            Console.WriteLine(-1);
                        }
                        else
                        {
                            Console.WriteLine(num);
                        }
                    }
                }
            }
        }
    }
}