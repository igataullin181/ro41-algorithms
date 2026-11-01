using System;

public static class ArrayOps
{
    // Sum: сумма всех элементов массива
    public static int Sum(int[] a)
    {
        int total = 0;
        for (int i = 0; i < a.Length; i++)
            total += a[i];
        return total;
    }

    // IndexOfMin: индекс первого минимального элемента
    // Начальное значение минимума берём из массива: a[0].
    public static int IndexOfMin(int[] a)
    {
        int minIndex = 0;
        for (int i = 1; i < a.Length; i++)
            if (a[i] < a[minIndex])
                minIndex = i; // строгое «<» сохраняет первый минимум
        return minIndex;
    }

    // CountGreater: количество элементов больше x
    public static int CountGreater(int[] a, int x)
    {
        int count = 0;
        for (int i = 0; i < a.Length; i++)
            if (a[i] > x)
                count++;
        return count;
    }

    // Reverse: разворот массива на месте.
    // Обмениваем a[i] и a[n - 1 - i] до середины массива.
    public static void Reverse(int[] a)
    {
        int n = a.Length;
        for (int i = 0; i < n / 2; i++)
        {
            int tmp = a[i];
            a[i] = a[n - 1 - i];
            a[n - 1 - i] = tmp;
        }
    }
}