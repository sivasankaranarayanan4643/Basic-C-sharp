using System;

namespace IfCondition;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter Your Mark: ");
        float mark=float.Parse(Console.ReadLine());
        if(mark>80 && mark<=100){
            Console.WriteLine("Grade A");
        }else if(60<=mark && mark<81){
            Console.WriteLine("Grade B");
        }else if(36<=mark && mark<61){
            Console.WriteLine("Grade C");
        }else if(mark>=0 && mark<36){
            Console.WriteLine("Grade D");
        }else{
            Console.WriteLine("Invalid Input");
        }
    }
}