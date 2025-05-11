StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n, q;

string[] strs = sr.ReadLine().Split(' ');

n = int.Parse(strs[0]);
q = int.Parse(strs[1]);

int[] duck = new int[n + 1];
int[] arr = new int[n + 1];

for (int i = 0; i < q; i++)
{
    duck[i] = int.Parse(sr.ReadLine());

    int index = duck[i];

    int blocked = 0;

    while (index > 0)
    {
        if (arr[index] != 0) blocked = arr[index];

        index /= 2;
    }

    arr[duck[i]] = duck[i];

    sw.WriteLine(blocked.ToString());
}
sr.Close();
sw.Close();