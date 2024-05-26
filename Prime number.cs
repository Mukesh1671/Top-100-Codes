using System;

public class PrimeNumber
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number < 2)
            {
                Console.Write($"{number} is not a Prime Number");
            }
            else
            {
                bool isPrime = true;
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write($"{number} is a Prime Number");
                }
                else
                {
                    Console.Write($"{number} is not a Prime Number");
                }
            }
        }
        else
        {
            Console.Write("Invalid input");
        }
    }
}
