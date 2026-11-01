using System;

class Program
{
    static void Main()
    {
        int[] digitInputs = { 0, 7, 12345, 1000 };
        foreach (int n in digitInputs)
            Console.WriteLine($"DigitSum({n}) = {Rec.DigitSum(n)}");

        (int x, int n)[] powInputs = { (2, 0), (2, 10), (5, 3), (7, 1) };
        foreach (var (x, n) in powInputs)
            Console.WriteLine($"Pow({x}, {n}) = {Rec.Pow(x, n)}");
    }
}