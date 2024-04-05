using System;
namespace DateeTime;
class Program{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2021,8,10,10,40,32);
        Console.WriteLine(date.Year);
        Console.WriteLine(date.Month);
        Console.WriteLine(date.Day);
        Console.WriteLine(date.Hour);
        Console.WriteLine(date.Minute);
        Console.WriteLine(date.Second);
        Console.Write("Enter the date in the format(yyyy/MM/dd hh:mm:ss tt): ");
        bool isValidDateArray=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out DateTime result1);
        while(!isValidDateArray){
            Console.Write("Enter the date in correct format(yyyy/MM/dd hh:mm:ss tt: )");
            isValidDateArray=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out  result1);
        }
        string date1=result1.ToString("yyyy/MM/dd/hh/mm/ss/tt");
        string[] dateArray=date1.Split("/");
        for(int i=dateArray.Length-1;i>=0;i--){
            Console.Write($"{dateArray[i]} ");
        }
        Console.WriteLine();
        Console.Write("Enter the date in the format(yyyy/MM/dd hh:mm:ss tt): ");
        bool isValidDate=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out DateTime result);
        while(!isValidDate){
            Console.Write("Enter the date in correct format(yyyy/MM/dd hh:mm:ss tt: )");
            isValidDate=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out  result);
        }
        Console.WriteLine(result.ToShortDateString());
    }
}