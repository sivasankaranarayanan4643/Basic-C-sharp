using System;
namespace DoWhile;

class Program{
    public static void Main(string[] args)
    {
        string opinion=string.Empty;
        do{
            opinion=string.Empty;
            Console.Write("Enter the number: ");
            int number=int.Parse(Console.ReadLine());
            if(number%2==0){
                Console.WriteLine("Given number is Even");
            }else{
                Console.WriteLine("Given number is Odd");
            }
            while(opinion!="no" &&  opinion!="yes"){
                Console.Write("Whether you want check another number?(yes/no) ");
                opinion=Console.ReadLine();
            }

        }while(opinion=="yes");
    }
}