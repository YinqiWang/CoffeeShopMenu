using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the coffee shop!");
        Console.WriteLine("Menu: espresso, latte, cappuccino, tea");
        Console.WriteLine("Please enter your selection: ");
        string selection = Console.ReadLine().ToLower();

        switch (selection)
        {
            case "espresso":
            case "latte":
                Console.WriteLine("That will be $3.50, please.");
                break;
            case "cappuccino":
                Console.WriteLine("That will be $4.00, please.");
                break;
            case "tea":
                Console.WriteLine("That will be $2.00, please.");
                break;
            default:
                Console.WriteLine("Invalid selection.");
                break;
        }
    }
}
