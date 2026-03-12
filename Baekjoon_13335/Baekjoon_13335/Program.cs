namespace Baekjoon_13335
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int n = int.Parse(input[0]);
            int w = int.Parse(input[1]);
            int l = int.Parse(input[2]);

            int time = 0;
            int currentWeight = 0;

            Queue<int> truck = new Queue<int>();
            Queue<int> bridge = new Queue<int>();
            string[] truckWeight = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                truck.Enqueue(int.Parse(truckWeight[i]));
            }

            for (int i = 0; i < w; i++)
            {
                bridge.Enqueue(0);
            }
            while (truck.Count > 0)
            {
                currentWeight -= bridge.Dequeue();

                if (truck.Peek() + currentWeight <= l)
                {
                    int nextTruck = truck.Dequeue(); // 트럭 한 대를 꺼내서 저장
                    bridge.Enqueue(nextTruck);       // 그 트럭을 다리에 올림
                    currentWeight += nextTruck;      // 현재 다리 무게에 더함
                }
                else
                {
                    bridge.Enqueue(0);
                }
                time++;
            }
            time += w;
            Console.WriteLine(time);
        }
    }
}
