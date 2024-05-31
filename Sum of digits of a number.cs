using System;

public class CustomizedSumOfDigits
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a positive integer: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number >= 0)
        {
            int sum = CalculateSumOfDigits(number);
            Console.WriteLine($"Sum of digits: {sum}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
        }
    }

    // Custom method to calculate the sum of digits
    private static int CalculateSumOfDigits(int num)
    {
        int digitSum = 0;
        while (num > 0)
        {
            digitSum += num % 10;
            num /= 10;
        }
        return digitSum;
    }
}
