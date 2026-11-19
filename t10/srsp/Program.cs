using System;

class Program
{
    static int failures = 0;

    static string Fmt(int[] a) => "{" + string.Join(", ", a) + "}";

    static void Check(string name, object expected, object actual)
    {
        bool ok = Equals(expected, actual);
        if (!ok) failures++;
        Console.WriteLine($"  {name}: ожидаю {expected}, факт {actual} — {(ok ? "OK" : "FAIL")}");
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("BubbleSort:");
        int[][] tests =
        {
            new int[] { },
            new int[] { 5 },
            new int[] { 1, 2, 3, 4, 5 },
            new int[] { 5, 4, 3, 2, 1 },
            new int[] { 3, 1, 3, 2, 3 }
        };
        int[] expectedCmp = { 0, 0, 4, 10, 9 };

        for (int i = 0; i < tests.Length; i++)
        {
            int[] t = tests[i];
            string before = Fmt(t);
            int cmp = ArrayAlgos.BubbleSort(t);
            Console.WriteLine($"{before} -> {Fmt(t)} | IsSorted={ArrayAlgos.IsSorted(t)} | сравнений={cmp}");
            Check("сравнений", expectedCmp[i], cmp);
            Check("IsSorted", true, ArrayAlgos.IsSorted(t));
        }

        Console.WriteLine("\nBubbleSort на отсортированном массиве из 1000 элементов:");
        int[] big = new int[1000];
        for (int i = 0; i < big.Length; i++) big[i] = i;
        Check("сравнений", 999, ArrayAlgos.BubbleSort(big));

        Console.WriteLine("\nCountOccurrences в {1, 2, 2, 2, 5, 7}:");
        int[] sorted = { 1, 2, 2, 2, 5, 7 };
        int[] xs = { 2, 1, 7, 3, 9 };
        int[] expected = { 3, 1, 1, 0, 0 };
        for (int i = 0; i < xs.Length; i++)
        {
            Check($"x = {xs[i]}", expected[i], ArrayAlgos.CountOccurrences(sorted, xs[i]));
        }

        Console.WriteLine(failures == 0 ? "\nВсе проверки пройдены" : $"\nОшибок: {failures}");
    }
}