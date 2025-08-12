using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Choose operation:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");

        Console.Write("Enter choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Sum = " + Add(a, b));
                break;
            case 2:
                Console.WriteLine("Difference = " + Subtract(a, b));
                break;
            case 3:
                Console.WriteLine("Product = " + Multiply(a, b));
                break;
            case 4:
                Console.WriteLine("Quotient = " + Divide(a, b));
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Subtract(int x, int y)
    {
        return x - y;
    }
    public static int Multiply(int x, int y)
    {
        return x * y;
    }
    public static int Divide (int x, int y)
    {
        return x / y;
    }
}

