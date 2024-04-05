using System;
using System.Globalization;
namespace String;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Main String: ");
        string mainString=Console.ReadLine();
        Console.Write("String to be Searched: ");
        string searchString=Console.ReadLine();
        int occurance=0;
        if(mainString.Contains(searchString)){
               for(int i=0;i<=(mainString.Length-searchString.Length);i++){
                if (mainString.Substring(i,2)==searchString){
                    occurance++;
                }
               }
            }
            Console.WriteLine($"String Searched Count is {occurance}");
         }
        
    }
