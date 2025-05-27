namespace Baejoon_1946
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                //지원자 수
                int N = int.Parse(Console.ReadLine());

                //서류, 면접 점수 저장
                var scores = new List<(int doc, int interview)>(N);

                for (int j = 0; j < N; j++)
                {
                    var part = Console.ReadLine().Split();
                    int docScore = int.Parse(part[0]);
                    int interviewScore = int.Parse(part[1]);
                    scores.Add((docScore, interviewScore));
                }
                //서류 기준 오름차순
                scores.Sort((a, b) => a.doc.CompareTo(b.doc));

                int cnt = 0;
                int bestInterv = int.MaxValue;

                foreach (var score in scores)
                {
                    if (score.interview < bestInterv)
                    {
                        cnt++;
                        bestInterv = score.interview;
                    }
                }

                Console.WriteLine(cnt);
            }
        }
    }
}
