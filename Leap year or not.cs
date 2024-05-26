using System;

public class FindingLeapYear
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Year: ");
        if (int.TryParse(Console.ReadLine(), out int year))
        {
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                Console.Write($"{year} is a leap year");
            }
            else
            {
                Console.Write($"{year} is not a leap year");
            }
        }
        else
        {
            Console.Write("Invalid input");
        }
    }
}
