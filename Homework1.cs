using System;

class Homework1
{
    public static void Run()
    {
        Console.WriteLine("Currency Converter");

        Console.Write("Enter amount in NPR: ");
        string input = Console.ReadLine();
        double amount = double.Parse(input);

        Console.WriteLine("Convert to: 1) USD 2) Euro 3) INR 4) JPY");
        string choice = Console.ReadLine();

        double result;

        switch (choice)
        {
            case "1":
                result = amount / 132;
                Console.WriteLine("Amount in USD: " + result);
                break;

            case "2":
                result = amount / 142;
                Console.WriteLine("Amount in Euro: " + result);
                break;

            case "3":
                result = amount / 1.6;
                Console.WriteLine("Amount in INR: " + result);
                break;

            case "4":
                result = amount * 9;  // Example rate
                Console.WriteLine("Amount in JPY: " + result);
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
