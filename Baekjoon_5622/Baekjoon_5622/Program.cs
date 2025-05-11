namespace Baekjoon_5622
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Dial(input));
        }

        static int Dial(string input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch(input[i])
                {
                    case <= 'C':
                        sum += 3;
                        break;
                    case <= 'F':
                        sum += 4;
                        break;
                    case <= 'I':
                        sum += 5;
                        break;
                    case <= 'L':
                        sum += 6;
                        break;
                    case <= 'O':
                        sum += 7;
                        break;
                    case <= 'S':
                        sum += 8;
                        break;
                    case <= 'V':
                        sum += 9;
                        break;
                    case <= 'Z':
                        sum += 10;
                        break;
                }
            }
            return sum;
        }
    }
}
