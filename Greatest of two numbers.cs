using System;

public class GreatestOfGivenNumber
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first integer number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the second integer number: ");
        string input2 = Console.ReadLine();

        if (int.TryParse(input1, out int firstNumber) && int.TryParse(input2, out int secondNumber))
        {
            // Both inputs are valid integers
            if (firstNumber > secondNumber)
            {
                Console.Write($"{firstNumber} is the greatest of the provided numbers");
            }
            else if (firstNumber < secondNumber)
            {
                Console.Write($"{secondNumber} is the greatest of the provided numbers");
            }
            else
            {
                Console.Write("Both numbers are the same");
            }
        }
        else
        {
            // Invalid input (non-numeric)
            Console.Write("Invalid input. Please enter valid integer numbers.");
        }
    }
}
