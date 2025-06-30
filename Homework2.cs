using System;

class Homework2
{
    public static void Run()
    {
        Console.WriteLine("User Preferences");

        Console.Write("Enter your age: ");
        string ageInput = Console.ReadLine();
        int age = int.Parse(ageInput);

        Console.Write("Enter your height in meters: ");
        string heightInput = Console.ReadLine();
        double height = double.Parse(heightInput);

        Console.Write("Do you want notifications? (true/false): ");
        string notifyInput = Console.ReadLine();
        bool wantsNotification = bool.Parse(notifyInput);

        Console.Write("How many notifications per day? ");
        string countInput = Console.ReadLine();
        int count = int.Parse(countInput);

        Console.WriteLine("\nYour age: " + age);
        Console.WriteLine("Your height: " + height + " meters");
        Console.WriteLine("Want notifications: " + wantsNotification);
        Console.WriteLine("Notifications per day: " + count);
    }
}
