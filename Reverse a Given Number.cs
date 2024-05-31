using System;

public class ReversingNumber
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a positive integer: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int originalNumber) && originalNumber > 0)
        {
            int reversedNumber = ReverseNumber(originalNumber);
            Console.WriteLine($"The reverse of {originalNumber} is {reversedNumber}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }

    private static int ReverseNumber(int num)
    {
        int reversed = 0;
        while (num > 0)
        {
            int lastDigit = num % 10;
            reversed = (reversed * 10) + lastDigit;
            num /= 10;
        }
        return reversed;
    }
}
