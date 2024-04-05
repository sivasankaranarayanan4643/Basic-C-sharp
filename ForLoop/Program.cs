using System;
namespace ForLoop;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Starting Number: ");
        int startNumber=int.Parse(Console.ReadLine());
        Console.Write("Enter the Ending Number: ");
        int endNumber=int.Parse(Console.ReadLine());
        int sum=0;
        for (int i=startNumber;i<=endNumber;i++)
        {
            sum+=(i*i);
        }
        Console.WriteLine(sum);
    }
}