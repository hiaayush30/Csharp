using System;

public class Person
{
    public string Name;
    public int Age;

    public Person()
    {
        Name = "Unknown";
        Age = 0;
    }

    public Person(string name)
    {
        Name = name;
        Age = 0;
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + Name + ", Age: " + Age);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.Display();

        Person p2 = new Person("Alice");
        p2.Display();

        Person p3 = new Person("Bob", 25);
        p3.Display();
    }
}

