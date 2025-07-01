using System;

public class ArithmeticOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return double.NaN;
        }
        return (double)a / b;
    }

    public int Modulo(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot modulo by zero.");
            return 0;
        }
        return a % b;
    }
}
