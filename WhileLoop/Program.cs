using System;

namespace WhileLoop;
class Program{
    public static void Main(string[] args)
    {
        int i=0;
        while(i<25){
            if(i%2==0){
                Console.WriteLine(i);
            }
            i++;
        }
        Console.WriteLine();
        int number;
        Boolean validation=false;
        Console.Write("Enter a Valid Number: ");
        validation=int.TryParse(Console.ReadLine(),out number);
        while(!validation){
            Console.Write("Invalid input format, Please enter the input in number format: ");
            validation=int.TryParse(Console.ReadLine(),out number);
        }
        Console.WriteLine(number);
    }
}