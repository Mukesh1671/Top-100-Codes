public class EvenOrOddNumber
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            string message = (result % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine($"The entered number is {message}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
