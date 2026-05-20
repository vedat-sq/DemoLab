namespace DemoConsoleApp;

public static class Calculator
{
    public static int Add(int a, int b) => a + b;
}

class Program
{
    static void Main()
    {
        // New code
        Console.WriteLine($"2 + 3 = {Calculator.Add(2, 3)}");
    }
}