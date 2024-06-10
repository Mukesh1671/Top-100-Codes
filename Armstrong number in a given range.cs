using System;

public class ArmstrongNumbers
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the start number: ");
        string input1 = Console.ReadLine();
        Console.WriteLine("Enter the end number: ");
        string input2 = Console.ReadLine();

        if (int.TryParse(input1, out int start) && int.TryParse(input2, out int end))
        {
            int[] cubeOfDigits = new int[10];
            for (int digit = 0; digit < 10; digit++)
            {
                cubeOfDigits[digit] = digit * digit * digit;
            }

            for (int num = start; num <= end; num++)
            {
                int originalNumber = num;
                int temp = num;  // Use a separate variable 'temp'
                int sum = 0;
                while (temp > 0)
                {
                    int lastDigit = temp % 10;
                    sum += cubeOfDigits[lastDigit];
                    temp /= 10;
                }

                if (originalNumber == sum)
                {
                    Console.WriteLine(sum);
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
