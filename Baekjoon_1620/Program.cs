using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);    
        int M = int.Parse(input[1]);    
        var Pocketmon = new Dictionary<string, int>(N);
        var names = new string[N+1];

        for(int i = 1; i<=N; i++)
        {
            string name = Console.ReadLine().Trim();
            Pocketmon[name] = i;
            names[i] = name;
        }
        
        var sb = new System.Text.StringBuilder();
        
        for (int i = 0; i < M; i++)
        {
            string m = Console.ReadLine().Trim();

            if (int.TryParse(m, out int idx))
            {
                sb.AppendLine(names[idx]);
            }
            else
            {
                sb.AppendLine(Pocketmon[m].ToString());
            }
        }

        Console.Write(sb);

    }
}