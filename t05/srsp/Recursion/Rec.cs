using System;

public static class Rec
{
    // DigitSum: сумма цифр неотрицательного числа
    // Базовый случай: n < 10, однозначное число — сумма равна самому числу.
    // Шаг рекурсии: последняя цифра (n % 10) + сумма цифр остальной части (n / 10).
    public static int DigitSum(int n)
    {
        if (n < 10)
            return n;
        return n % 10 + DigitSum(n / 10);
    }

    // Pow: x в степени n (n >= 0), без Math.Pow
    // Базовый случай: n == 0, любая степень 0 равна 1.
    // Шаг рекурсии: x^n = x * x^(n-1).
    public static long Pow(int x, int n)
    {
        if (n == 0)
            return 1;
        return x * Pow(x, n - 1);
    }
}