using System;

namespace Methods;
class Program{
    public static void Main(string[] args)
    {
        bool operation=true;
        do{
        Console.Write("Enter the First Number: ");
        double number1=double.Parse(Console.ReadLine());
        Console.Write("Enter the Second Number: ");
        double number2=double.Parse(Console.ReadLine());
        char selectedOption;
        bool correctOption=true;
        do{
            correctOption=true;
            selectedOption=options();
            switch (selectedOption){
                case '1':
                {   
                    Console.WriteLine(Add(number1,number2));
                    break;
                }
                case '2':
                {
                    Console.WriteLine(Sub(number1,number2));
                    break;
                }
                case '3':{
                    Console.WriteLine(Multiply(number1,number2));
                    break;
                }
                case '4':{
                    Console.WriteLine(Division(number1,number2));
                    break;
                }
                default :
                {
                    Console.WriteLine("Choose the correct option:");
                    correctOption=false;
                    break;
                }

            }
        }while(!correctOption);
        Console.Write("Enter yes if you want to do another operation: ");
        string repeatOperation=Console.ReadLine();
        if(repeatOperation!="yes"){
            operation=false;
        }
        }while(operation);
    }
    static char options(){
        Console.WriteLine("Enter the option from the menu given below \n1.Addition\n2.Subtraction\n3.Multiplication \n4.Division ");
        char selectedOption=char.Parse(Console.ReadLine());
        return selectedOption;
    }
    static double Add(double a,double b){
        double c=a+b;
        return c;
    }
    static double Sub(double a, double b){
        double c=a-b;
        return c;
    }
    static double Multiply(double a, double b){
        double c=a*b;
        return c;
    }
    static double Division(double a, double b){
        double c=a/b;
        return c;
    }
}