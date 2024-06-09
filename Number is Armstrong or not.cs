using System;

class HelloWorld {
    static void Main() {
        Console.WriteLine("Enter the number to find whether it is an Armstrong number or not: ");
        if (int.TryParse(Console.ReadLine(), out int number)) {
            int originalNumber = number;
            int sum = 0;
            while (number > 0) {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, 3);
                number /= 10;
            }
            if (originalNumber == sum) {
                Console.WriteLine($"{originalNumber} is an Armstrong number.");
            }
            else {
                Console.WriteLine($"{originalNumber} is not an Armstrong number.");
            }
        }
        else {
            Console.WriteLine("Invalid input");
        }
    }
}
