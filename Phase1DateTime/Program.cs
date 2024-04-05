using System;
namespace PHASE1DATETIME;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the date in the foramt(dd/MM/yyyy): ");
        bool isDate=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out DateTime date);
        Console.WriteLine(isDate? "Yes":"No");
    }
}