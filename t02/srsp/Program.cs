using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число n (не меньше 0): ");
        string text = Console.ReadLine();

        if (!int.TryParse(text, out int n) || n < 0)
        {
            Console.WriteLine("Ошибка: нужно ввести целое число не меньше 0.");
            return;
        }

        int sum = 0;
        int count = 0;

        do
        {
            int digit = n % 10;
            sum += digit;
            count++;
            n /= 10;
        } while (n > 0);

        Console.WriteLine($"Цифр: {count}, сумма цифр: {sum}");
    }
}
