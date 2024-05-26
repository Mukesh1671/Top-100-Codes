using System;

public class SumOfNumbersInAGivenRange
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the start integer: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter the end integer: ");
        int end = int.Parse(Console.ReadLine());

        if (start > end)
        {
            Console.WriteLine("Invalid input. Start should be less than or equal to end.");
        }
        else
        {
            int sum = (end - start + 1) * (start + end) / 2;
            Console.WriteLine($"Sum of integers from {start} to {end} is {sum}");
        }
    }
}
