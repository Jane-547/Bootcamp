using System.Diagnostics; // Это чтобы работал счетчик времени

// int size = 10;

// int m = 3;
// int[] array = Enumerable.Range(1, size)
//                         .Select(item => Random.Shared.Next(10))
//                         .ToArray();

// System.Console.WriteLine($"[{string.Join(", ", array)}]");

// // Stopwatch sw = new();
// // sw.Start();

// int max = 0;
// for (int i = 0; i < size - m; i++)
// {
//     int t = 0;
//     for (int j = 0; j < m; j++)
//     {
//         t = t + array[i];
//     }
//     if (t > max) max = t;
// }
// // sw.Stop();
// // System.Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
// System.Console.WriteLine(max);

// ---------------------------------------------------------------------------------------------------------------------------------------------------------
int size = 10;  //  То же самое вариант № 2

int m = 3;
int[] array = Enumerable.Range(1, size)
                        .Select(item => Random.Shared.Next(10))
                        .ToArray();

System.Console.WriteLine($"[{string.Join(", ", array)}]");

Stopwatch sw = new();
sw.Start();

int max = 0;
for (int j = 0; j < m; j++) max += array[j];
int t = max;
for (int i = 1; i < size - m; i++)
{
    t = t - array[i - 1] + array[i + (m - 1)];
    if (t > max) max = t;
}
sw.Stop();
System.Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
System.Console.WriteLine(max);

// ---------------------------------------------------------------------------------------------------------------------------------------------------------

