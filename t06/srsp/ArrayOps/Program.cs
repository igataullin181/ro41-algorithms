using System;

class Program
{
    static void Main()
    {
        int[][] tests =
        {
            new[] { 4, 1, 7, 3, 9 },
            new[] { 5 },
            new[] { -2, -7, -4 },
            new[] { 2, 2, 2 }
        };

        foreach (int[] source in tests)
        {
            int[] a = (int[])source.Clone();

            Console.WriteLine($"Массив: {string.Join(", ", source)}");
            Console.WriteLine($"  Sum = {ArrayOps.Sum(a)}");
            Console.WriteLine($"  IndexOfMin = {ArrayOps.IndexOfMin(a)}");
            Console.WriteLine($"  CountGreater(x = 2) = {ArrayOps.CountGreater(a, 2)}");

            ArrayOps.Reverse(a);
            Console.WriteLine($"  После Reverse: {string.Join(", ", a)}");
            Console.WriteLine();
        }
    }
}