using System;
using System.Text;

public static class TextTools
{
    // Количество слов; подряд идущие пробелы не создают пустых слов
    public static int CountWords(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        int count = 0;
        bool inWord = false;
        foreach (char c in s)
        {
            if (char.IsWhiteSpace(c))
            {
                inWord = false;
            }
            else if (!inWord)
            {
                inWord = true;
                count++;
            }
        }
        return count;
    }

    // Палиндром без учёта регистра и пробелов
    public static bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s)) return true;

        var sb = new StringBuilder(s.Length);
        foreach (char c in s)
        {
            if (!char.IsWhiteSpace(c))
                sb.Append(char.ToLowerInvariant(c));
        }

        int i = 0, j = sb.Length - 1;
        while (i < j)
        {
            if (sb[i] != sb[j]) return false;
            i++;
            j--;
        }
        return true;
    }

    // "Ахметов Ерлан Серикұлы" -> "А. Е. С."
    public static string Initials(string fullName)
    {
        if (string.IsNullOrWhiteSpace(fullName)) return "";

        var sb = new StringBuilder();
        bool inWord = false;
        foreach (char c in fullName)
        {
            if (char.IsWhiteSpace(c))
            {
                inWord = false;
            }
            else if (!inWord)
            {
                inWord = true;
                if (sb.Length > 0) sb.Append(' ');
                sb.Append(char.ToUpperInvariant(c)).Append('.');
            }
        }
        return sb.ToString();
    }

    // Повторяет строку n раз; при n <= 0 возвращает пустую строку
    public static string Repeat(string s, int n)
    {
        if (string.IsNullOrEmpty(s) || n <= 0) return "";

        var sb = new StringBuilder(s.Length * n);
        for (int k = 0; k < n; k++)
            sb.Append(s);
        return sb.ToString();
    }
}