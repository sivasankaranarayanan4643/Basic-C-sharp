using System;
using System.Diagnostics;

namespace SwitchCase;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the First Number: ");
        float number1=float.Parse(Console.ReadLine());
        Console.Write("Enter the Second Number: ");
        float number2=float.Parse(Console.ReadLine());
        Console.Write("Enter the Operand(+, -, *, /, %): ");
        char operand=char.Parse(Console.ReadLine());
        switch(operand){
            case '+':{
                Console.WriteLine(number1+number2);
                break;
            }case '-':{
                Console.WriteLine(number1-number2);
                break;
            }case '*':{
                Console.WriteLine(number1*number2);
                break;
            }case '/':{
                Console.WriteLine(number1/number2);
                break;
            }case '%':{
                Console.WriteLine(number1%number2);
                break;
            }default:{
                Console.WriteLine("Operation is Invalid");
                break;
            }
        }
    }
}
