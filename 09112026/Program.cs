using System;
using System.Collections.Generic;

class Device
{
    public string Name;
    public string Description;

    public Device(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Device sound");
    }

    public void Show()
    {
        Console.WriteLine("Name: " + Name);
    }

    public void Desc()
    {
        Console.WriteLine("Description: " + Description);
    }
}

class Kettle : Device
{
    public Kettle(string name, string description) : base(name, description) { }

    public override void Sound()
    {
        Console.WriteLine("Whistle!");
    }
}

class Microwave : Device
{
    public Microwave(string name, string description) : base(name, description) { }

    public override void Sound()
    {
        Console.WriteLine("Beep beep!");
    }
}

class Car : Device
{
    public Car(string name, string description) : base(name, description) { }

    public override void Sound()
    {
        Console.WriteLine("Vroom!");
    }
}

class Steamboat : Device
{
    public Steamboat(string name, string description) : base(name, description) { }

    public override void Sound()
    {
        Console.WriteLine("Toot toot!");
    }
}

// Task 2

class Course
{
    public string Name;
    public int Duration;

    public Course(string name, int duration)
    {
        Name = name;
        Duration = duration;
    }

    public override string ToString()
    {
        return "Course: " + Name + ", Duration: " + Duration + " hours";
    }
}

class OnlineCourse : Course
{
    public string Platform;

    public OnlineCourse(string name, int duration, string platform)
        : base(name, duration)
    {
        Platform = platform;
    }

    public override string ToString()
    {
        return "Course: " + Name + ", Duration: " + Duration +
               " hours, Platform: " + Platform;
    }
}

// Task 3

abstract class Product
{
    public string Name;
    public double Price;

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract double CalculateDiscount();
}

class Electronics : Product
{
    public Electronics(string name, double price) : base(name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.10;
    }
}

class Furniture : Product
{
    public Furniture(string name, double price) : base(name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.20;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("TASK 1");

        Device[] devices =
        {
            new Kettle("Kettle", "Electric kettle"),
            new Microwave("Microwave", "Kitchen microwave"),
            new Car("Car", "Passenger car"),
            new Steamboat("Steamboat", "Steam-powered ship")
        };

        foreach (Device device in devices)
        {
            device.Show();
            device.Desc();
            device.Sound();
            Console.WriteLine();
        }

        Console.WriteLine("TASK 2");

        Course course = new Course("C#", 40);
        OnlineCourse onlineCourse = new OnlineCourse("Python", 30, "Udemy");

        Console.WriteLine(course);
        Console.WriteLine(onlineCourse);

        Console.WriteLine();

        Console.WriteLine("TASK 3");

        List<Product> products = new List<Product>();

        products.Add(new Electronics("Laptop", 30000));
        products.Add(new Electronics("Phone", 15000));
        products.Add(new Furniture("Table", 5000));
        products.Add(new Furniture("Chair", 2000));

        foreach (Product product in products)
        {
            Console.WriteLine("Product: " + product.Name);
            Console.WriteLine("Price: " + product.Price);
            Console.WriteLine("Discount: " + product.CalculateDiscount());
            Console.WriteLine();
        }
    }
}