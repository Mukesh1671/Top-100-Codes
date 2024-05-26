using System;

public class SumOfNaturalNumbers
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a positive integer: ");
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            // Calculate the sum using the arithmetic sum formula
            int sum = result * (result + 1) / 2;
            Console.WriteLine($"Sum of natural numbers up to {result} is {sum}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer.");
        }
    }
}
