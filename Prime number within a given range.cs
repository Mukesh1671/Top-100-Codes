using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the start number of the range: ");
        string input1 = Console.ReadLine();
        Console.Write("Enter the end number of the range: ");
        string input2 = Console.ReadLine();

        if (int.TryParse(input1, out int start) && int.TryParse(input2, out int end))
        {
            List<int> primeNumbers = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (i < 2)
                {
                    continue;
                }
                else if (IsPrime(i))
                {
                    primeNumbers.Add(i);
                }
            }

            // Remove the last character (", ") from the output
            string output = string.Join(", ", primeNumbers);
            output = output.Remove(output.Length - 2);

            Console.WriteLine($"Prime numbers in the given range: {output}");
        }
        else
        {
            Console.Write("Invalid input");
        }
    }

    private static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int j = 2; j * j <= num; j++)
        {
            if (num % j == 0)
            {
                return false;
            }
        }

        return true;
    }
}
