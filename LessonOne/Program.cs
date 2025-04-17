using System.Diagnostics;

List<int> primeNum = new List<int> { 2 };

int count = 0;

var start = Stopwatch.GetTimestamp();

for (int i = 3; i < 1000000; i++)
{
    for (int j = 0; j < primeNum.Count; j++)
    {
        int number = primeNum[j];

        if (i % number == 0)
        {
            count = 0;
            break;
        }

        count++;

        if (count == primeNum.Count)
        {
            count = 0;
            primeNum.Add(i);
        }
    }
}

Console.WriteLine("Duration: {0}", Stopwatch.GetElapsedTime(start));

Console.WriteLine("Primes " + string.Join(", ", primeNum));