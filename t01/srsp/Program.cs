using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество секунд: ");
        string text = Console.ReadLine();

        if (!int.TryParse(text, out int seconds) || seconds < 0)
        {
            Console.WriteLine("Ошибка: нужно ввести целое число не меньше 0.");
            return;
        }

        int hours = seconds / 3600;
        int rest = seconds % 3600;
        int minutes = rest / 60;
        int secs = rest % 60;

        Console.WriteLine($"{hours} ч {minutes} мин {secs} с");
    }
}
