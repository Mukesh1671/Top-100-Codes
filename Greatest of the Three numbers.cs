using System;

public class GreatestOfThreeNumbers
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the First number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the Second number: ");
        string input2 = Console.ReadLine();

        Console.Write("Enter the Third number: ");
        string input3 = Console.ReadLine();

        if (int.TryParse(input1, out int firstNumber) && int.TryParse(input2, out int secondNumber) && int.TryParse(input3, out int thirdNumber))
        {
            if (firstNumber == secondNumber && firstNumber == thirdNumber)
            {
                Console.Write($"All three numbers are equal");
            }
            else if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.Write($"The greatest of the three numbers is {firstNumber}");
            }
            else if (firstNumber < secondNumber && secondNumber > thirdNumber)
            {
                Console.Write($"The greatest of the three numbers is {secondNumber}");
            }
            else
            {
                Console.Write($"The greatest of the three numbers is {thirdNumber}");
            }
        }
        else
        {
            Console.Write("Invalid input");
        }
    }
}
