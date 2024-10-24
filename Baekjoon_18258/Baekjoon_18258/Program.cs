using System.Text;
using System.IO;

namespace Baekjoon_18258
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            Queue<int> queue = new Queue<int>();
            int back = 0;
            int N = int.Parse(sr.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] input = sr.ReadLine().Split();
                string fun = input[0];
                switch (fun)
                {
                    case "push":
                        int value = int.Parse(input[1]);
                        back = value;
                        queue.Enqueue(value);
                        break;

                    case "pop":
                        if (queue.Count == 0)
                        {
                            sw.WriteLine("-1");
                        }
                        else
                        {
                            sw.WriteLine(queue.Dequeue().ToString());

                        }
                        break;

                    case "empty":
                        if (queue.Count == 0)
                        {
                            sw.WriteLine("1");
                        }
                        else
                        {
                            sw.WriteLine("0");
                        }
                        break;

                    case "size":
                        sw.WriteLine(queue.Count().ToString());
                        
                        break;

                    case "front":
                        if (queue.Count == 0)
                        {
                            sw.WriteLine("-1");
                        }
                        else
                        {
                            sw.WriteLine(queue.Peek().ToString());
                        }
                        break;

                    case "back":
                        if (queue.Count == 0)
                        {
                            sw.WriteLine("-1");
                        }
                        else
                        {
                            sw.WriteLine(back.ToString());
                        }

                        break;
                }
            }
            sr.Close();
            sw.Close();
        }
    }
}