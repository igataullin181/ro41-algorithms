using System;

class Program
{
    static int failures = 0;

    static string Show<T>(T value) =>
        value is string s ? "\"" + s + "\"" : (value == null ? "null" : value.ToString());

    static void Check<T>(string input, string method, T expected, T actual)
    {
        bool ok = Equals(expected, actual);
        if (!ok) failures++;
        Console.WriteLine($"Вход: \"{input}\" | {method} | ожидаю: {Show(expected)} | факт: {Show(actual)} | {(ok ? "OK" : "FAIL")}");
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string[] inputs =
        {
            "",
            "   ",
            " a  b ",
            "А роза упала на лапу Азора",
            "Ахметов Ерлан"
        };

        int[] counts = { 0, 0, 2, 6, 2 };
        bool[] pals = { true, true, false, true, false };
        string[] inits = { "", "", "A. B.", "А. Р. У. Н. Л. А.", "А. Е." };

        for (int i = 0; i < inputs.Length; i++)
        {
            string s = inputs[i];

            Check(s, "CountWords", counts[i], TextTools.CountWords(s));
            Check(s, "IsPalindrome", pals[i], TextTools.IsPalindrome(s));
            Check(s, "Initials", inits[i], TextTools.Initials(s));
            Check(s, "Repeat(s, 2)", s + s, TextTools.Repeat(s, 2));

            Console.WriteLine();
        }

        Console.WriteLine(failures == 0 ? "Все проверки пройдены" : $"Ошибок: {failures}");
    }
}