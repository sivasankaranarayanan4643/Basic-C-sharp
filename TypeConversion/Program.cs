using System;

namespace TypeConversion;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter Your Name: ");
        string name=Console.ReadLine();
        Console.Write("Enter Age: ");
        int age=int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject1: ");
        double subject1=double.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject2: ");
        double subject2=double.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject3: ");
        double subject3=double.Parse(Console.ReadLine());
        Console.Write("Enter Grade: ");
        char grade=char.Parse(Console.ReadLine());
        Console.Write("Enter mobile number: ");
        long mobileNum=long.Parse(Console.ReadLine());
        Console.Write("Enter Mail Id: ");
        string mail=Console.ReadLine();
        double total=subject1+subject2+subject3;
        double average=total/3;
        Console.WriteLine("Trainee Details Are:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Mobile: {mobileNum}");
        Console.WriteLine($"Mark1: {subject1}");
        Console.WriteLine($"Mark2: {subject2}");
        Console.WriteLine($"Mark3: {subject3}");
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Mail Id: {mail}");

    }
}