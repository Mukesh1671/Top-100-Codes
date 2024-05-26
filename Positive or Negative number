using System;

public class PositiveOrNegative
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int result;
        if (int.TryParse(Console.ReadLine(), out result))
        {
            if (result == 0)
            {
                Console.WriteLine("The entered number is neither positive nor negative");
            }
            else if (result < 0)
            {
                Console.WriteLine("The entered number is negative");
            }
            else
            {
                Console.WriteLine("The entered number is positive");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
