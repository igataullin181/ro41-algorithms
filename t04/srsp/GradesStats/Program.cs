int count = 0;
int sum = 0;
int fives = 0;

while (true)
{
    int g = Grades.Read();

    if (g == Grades.Stop)
    {
        break;
    }

    if (Grades.IsValid(g))
    {
        count++;
        sum += g;

        if (g == Grades.Max)
        {
            fives++;
        }
    }
}

Grades.PrintStats(count, sum, fives);

static class Grades
{
    public const int Min = 2;
    public const int Max = 5;
    public const int Stop = 0;

    public static int Read()
    {
        string text = Console.ReadLine();
        return int.TryParse(text, out int g) ? g : -1;
    }

    public static bool IsValid(int g)
    {
        return g >= Min && g <= Max;
    }

    public static void PrintStats(int count, int sum, int fives)
    {
        if (count == 0)
        {
            Console.WriteLine("Оценок нет");
            return;
        }

        double avg = (double)sum / count;
        Console.WriteLine($"Оценок: {count}, сумма: {sum}, средний балл: {avg:F2}, отличных: {fives}");
    }
}
