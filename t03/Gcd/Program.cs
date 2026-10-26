using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        string textA = Console.ReadLine();
        Console.Write("Введите b: ");
        string textB = Console.ReadLine();

        if (!int.TryParse(textA, out int a) || !int.TryParse(textB, out int b)
            || a < 0 || b < 0 || (a == 0 && b == 0))
        {
            Console.WriteLine("Ошибка: нужно целые a и b, a ≥ 0, b ≥ 0, не оба равны 0.");
            return;
        }

        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }

        Console.WriteLine($"НОД = {a}");
    }
}
