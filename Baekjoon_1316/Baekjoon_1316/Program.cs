namespace Baekjoon_1316
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int groupWordCount = 0;

            for (int i = 0; i < T; i++)
            {
                string word = Console.ReadLine();
                if(IsGroupWord(word))
                {
                    groupWordCount++;
                }
            }
            Console.WriteLine(groupWordCount);
        }

        static bool IsGroupWord(string word)
        {
            List<char> appearChars = new List<char>();
            if (word.Length > 0)
            {
                appearChars.Add(word[0]);
            }

            for(int i = 1; i<word.Length; i++)
            {
                if (word[i] != word[i-1])
                {
                    if(appearChars.Contains(word[i]))
                    {
                        return false;
                    }
                    appearChars.Add(word[i]);
                }
            }

            return true;
        }
    }
}
