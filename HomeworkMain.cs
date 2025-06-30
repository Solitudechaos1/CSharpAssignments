using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter 1 for Currency Converter");
        Console.WriteLine("Enter 2 for User Preferences");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Homework1.Run();
        }
        else if (choice == "2")
        {
            Homework2.Run();
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }
}
