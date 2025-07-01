//Write a program to add,subtract,multiply,divide and modulus of two numbers//
using System;

class Program
{
    static void Main()
    {
        int number1, number2, sum, difference, product, remainder;
        double quotient;

        Console.WriteLine("Enter the first number:");
        number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        number2 = int.Parse(Console.ReadLine());

        ArithmeticOperations obj = new ArithmeticOperations();

        sum = obj.Add(number1, number2);
        difference = obj.Subtract(number1, number2);
        product = obj.Multiply(number1, number2);
        quotient = obj.Divide(number1, number2);
        remainder = obj.Modulo(number1, number2);

        Console.WriteLine("The sum of two numbers is " + sum);
        Console.WriteLine("The difference of two numbers is " + difference);
        Console.WriteLine("The product of two numbers is " + product);
        Console.WriteLine("The quotient of two numbers is " + quotient);
        Console.WriteLine("The remainder of two numbers is " + remainder);
    }
}