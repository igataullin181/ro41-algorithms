using System;

public static class ArrayAlgos
{
    // true, если a[0] <= a[1] <= ... <= a[n-1]
    public static bool IsSorted(int[] a)
    {
        if (a == null) throw new ArgumentNullException(nameof(a));

        for (int i = 1; i < a.Length; i++)
            if (a[i - 1] > a[i]) return false;
        return true;
    }

    // Пузырьковая сортировка на месте с ранним выходом; возвращает число сравнений
    public static int BubbleSort(int[] a)
    {
        if (a == null) throw new ArgumentNullException(nameof(a));

        int comparisons = 0;
        int n = a.Length;
        for (int pass = 0; pass < n - 1; pass++)
        {
            bool swapped = false;
            for (int j = 0; j < n - 1 - pass; j++)
            {
                comparisons++;
                if (a[j] > a[j + 1])
                {
                    (a[j], a[j + 1]) = (a[j + 1], a[j]);
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
        return comparisons;
    }

    // Первый индекс i, где a[i] >= x (strict = false) или a[i] > x (strict = true)
    private static int Bound(int[] a, int x, bool strict)
    {
        int lo = 0, hi = a.Length;
        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            bool goRight = strict ? a[mid] <= x : a[mid] < x;
            if (goRight) lo = mid + 1;
            else hi = mid;
        }
        return lo;
    }

    // Количество вхождений x: позиция первого > x минус позиция первого >= x
    public static int CountOccurrences(int[] sortedA, int x)
    {
        if (sortedA == null) throw new ArgumentNullException(nameof(sortedA));

        return Bound(sortedA, x, true) - Bound(sortedA, x, false);
    }
}