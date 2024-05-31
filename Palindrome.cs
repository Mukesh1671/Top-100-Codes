using System;

public class PalindromeNumber
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a positive integer: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int originalNumber) && originalNumber > 0)
        {
            Console.WriteLine(CheckingPalindrome(originalNumber));
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
            reversed = (reversed * 10) + (num % 10);
            num /= 10;
        }
        return reversed;
    }

    private static string CheckingPalindrome(int num)
    {
        int reversed = ReverseNumber(num);
        return reversed == num ? $"{num} is a Palindrome number" : $"{num} is not a Palindrome number";
    }
}
