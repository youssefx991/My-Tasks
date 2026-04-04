#region Task1
using System.Diagnostics;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text.Json.Serialization;

void Task1()
{
    Console.Write("Enter array size: ");
    int n = int.Parse(Console.ReadLine());

    int[] arr = new int[n];

    int max_distance = -1;
    int start = -1;
    int end = -1;

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Enter element {i + 1} : ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if (arr[i] == arr[j])
            {
                if (j - i - 1 >= max_distance)
                {
                    max_distance = j - i - 1;
                    start = i;
                    end = j;
                }
            }
        }
    }
    Console.WriteLine($"max distance is between arr[{start}] and arr[{end}] = {max_distance}");
    Console.WriteLine("======================================================================================\n\n");
}
#endregion


#region Task2
void Task2()
{
    Console.Write("Enter string: ");
    string s = Console.ReadLine();

    string[] words = s.Split(' ');
    int n = words.Length;

    int start = 0;
    int end = n - 1;

    while (start < end)
    {
        string temp = words[start];
        words[start] = words[end];
        words[end] = temp;

        start++;
        end--;
    }

    s = String.Join(" ", words);

    Console.WriteLine($"Reversed string: {s}");
    Console.WriteLine("======================================================================================\n\n");
}
#endregion


#region Task3_1
void Task3_1()
{

    int count = 0;
    Stopwatch sw = Stopwatch.StartNew();
    for (int i = 1; i < 100000000; i++)
    {
        string str_num = i.ToString();
        count += str_num.Count('1');
    }

    sw.Stop();
    Console.WriteLine($"number of 1's = {count} found in {sw.ElapsedMilliseconds} using strings");
    Console.WriteLine("======================================================================================\n\n");
}
#endregion

#region Task3_2
void Task3_2()
{

    int count = 0;
    Stopwatch sw = Stopwatch.StartNew();
    for (int i = 1; i < 100000000; i++)
    {
        int temp_i = i;
        while (temp_i != 0)
        {
            if (temp_i % 10 == 1)
                count++;
            temp_i /= 10;
        }
    }

    sw.Stop();
    Console.WriteLine($"number of 1's = {count} found in {sw.ElapsedMilliseconds} using numbers only");
    Console.WriteLine("======================================================================================\n\n");
}
#endregion

#region Task3_3
void Task3_3()
{
    // total occurances = total trials * number of positions * probability per position

    Stopwatch sw = Stopwatch.StartNew();
    double probability_per_position = 1d / 10d;
    long number_of_positions = 8;
    long total_trials = (long)Math.Pow(10, 8);

    double count = total_trials * number_of_positions * probability_per_position;
    sw.Stop();
    Console.WriteLine($"number of 1's = {count} found in {sw.ElapsedMilliseconds} using formula");
    Console.WriteLine("======================================================================================\n\n");
}
#endregion


#region Task4_BF
void Task4_BF()
{
    float budget = 183.23f;
    float bagVolume = 64.11f;
    int people = 7;
    int Npresents = 12;
    float[] presentVolume = new float[Npresents];
    float[] presentPrice = new float[Npresents];

    presentVolume[0] = 4.53f;
    presentPrice[0] = 12.23f;
    presentVolume[1] = 9.11f;
    presentPrice[1] = 45.03f;
    presentVolume[2] = 4.53f;
    presentPrice[2] = 12.23f;
    presentVolume[3] = 6.00f;
    presentPrice[3] = 32.93f;
    presentVolume[4] = 1.04f;
    presentPrice[4] = 6.99f;
    presentVolume[5] = 0.87f;
    presentPrice[5] = 0.46f;
    presentVolume[6] = 2.57f;
    presentPrice[6] = 7.34f;
    presentVolume[7] = 19.45f;
    presentPrice[7] = 65.98f;
    presentVolume[8] = 65.59f;
    presentPrice[8] = 152.13f;
    presentVolume[9] = 14.14f;
    presentPrice[9] = 7.23f;
    presentVolume[10] = 16.66f;
    presentPrice[10] = 10.00f;
    presentVolume[11] = 13.53f;
    presentPrice[11] = 25.25f;

    Stopwatch sw = Stopwatch.StartNew();
    float max_amount = PresentList_BF(budget, bagVolume, people, Npresents, presentVolume, presentPrice);
    sw.Stop();
    Console.WriteLine($"max amount of money that will be spent = {max_amount} found in {sw.ElapsedMilliseconds} using Brute Force");
    Console.WriteLine("======================================================================================\n\n");
}



float PresentList_BF(float budget, float bagVolume, int people,
    int Npresents, float[] presentVolume, float[] presentPrice)
{
    float solve(int index, int count, float volume, float price)
    {
        if (volume > bagVolume || price > budget)
            return -1;
        if (index >= Npresents)
        {
            if (count >= 0 && count % people == 0)
            {
                //Console.WriteLine($"Volume: {volume}");
                //Console.WriteLine($"Count: {count}");
                return price;
            }
            else
                return -1;
        }


        float max_take =
            solve(index + 1, count + 1, volume + presentVolume[index], price + presentPrice[index]);
        float max_leave =
            solve(index + 1, count, volume, price);

        return float.Max(max_take, max_leave);
    }

    return solve(0, 0, 0, 0);
} 
#endregion


#region Task4_DP
void Task4_DP()
{
    float budget = 183.23f;
    float bagVolume = 64.11f;
    int people = 7;
    int Npresents = 12;
    float[] presentVolume = new float[Npresents];
    float[] presentPrice = new float[Npresents];

    presentVolume[0] = 4.53f;
    presentPrice[0] = 12.23f;
    presentVolume[1] = 9.11f;
    presentPrice[1] = 45.03f;
    presentVolume[2] = 4.53f;
    presentPrice[2] = 12.23f;
    presentVolume[3] = 6.00f;
    presentPrice[3] = 32.93f;
    presentVolume[4] = 1.04f;
    presentPrice[4] = 6.99f;
    presentVolume[5] = 0.87f;
    presentPrice[5] = 0.46f;
    presentVolume[6] = 2.57f;
    presentPrice[6] = 7.34f;
    presentVolume[7] = 19.45f;
    presentPrice[7] = 65.98f;
    presentVolume[8] = 65.59f;
    presentPrice[8] = 152.13f;
    presentVolume[9] = 14.14f;
    presentPrice[9] = 7.23f;
    presentVolume[10] = 16.66f;
    presentPrice[10] = 10.00f;
    presentVolume[11] = 13.53f;
    presentPrice[11] = 25.25f;

    Stopwatch sw = Stopwatch.StartNew();
    float max_amount = PresentList_DP(budget, bagVolume, people, Npresents, presentVolume, presentPrice);
    sw.Stop();
    Console.WriteLine($"max amount of money that will be spent = {max_amount} found in {sw.ElapsedMilliseconds} using DP");
    Console.WriteLine("======================================================================================\n\n");
}
float PresentList_DP(float budget, float bagVolume, int people,
    int Npresents, float[] presentVolume, float[] presentPrice)
{
    Dictionary<(int, int, float), float> dp = new Dictionary<(int, int, float), float>();
    float solve(int index, int count, float volume, float price)
    {
        (int, int, float) key = (index, count, (float)Math.Round(volume, 2));

        if (dp.ContainsKey(key))
            return dp[key];
        if (volume > bagVolume || price > budget)
            return -1;
        if (index >= Npresents)
        {
            if (count >= 0 && count % people == 0)
            {
                return price;
            }
            else
                return -1;
        }

        float max_take = -1;
        (int, int, float) take_key = (index + 1, count + 1, (float)Math.Round(volume + presentVolume[index], 2));
        if (dp.ContainsKey(take_key))
            max_take = dp[take_key];
        else
        {
            dp[take_key] = solve(index + 1, count + 1, volume + presentVolume[index], price + presentPrice[index]);
            max_take = dp[take_key];
        }

        float max_leave = -1;
        (int, int, float) leave_key = (index + 1, count, (float)Math.Round(volume, 2));
        if (dp.ContainsKey(leave_key))
            max_leave = dp[leave_key];
        else
        {
            dp[leave_key] = solve(index + 1, count, volume, price);
            max_leave = dp[leave_key];
        }

        dp[key] = float.Max(max_take, max_leave);
        return dp[key];
    }

    return solve(0, 0, 0, 0);
}
#endregion




Task1();
Task2();
Task3_1(); // 80000000
Task3_2(); // 80000000
Task3_3(); // 80000000
Task4_BF(); // 182.96999
Task4_DP(); // 182.96999


