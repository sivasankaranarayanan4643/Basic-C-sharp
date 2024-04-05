using System;

namespace Array;

class Program{
    public static void Main(string[] args)
    {
        string[] names=new string[5]{"Siva", "Mani", "Kumar","Siva", "Vasanth"};
        
        for(int j=0;j<names.Length;j++){
            Console.WriteLine(names[j]);
        }

        Console.Write("Enter the Name to  search: ");
        string searchName=Console.ReadLine();
        bool isPresent=false;

        for(int k=0;k<names.Length;k++){
            if(names[k]==searchName){
                if(!isPresent){
                    isPresent=true;
                    Console.WriteLine("The name is present in array");
                }if(isPresent){
                Console.WriteLine(k);
                }
                
            }
        }
        if(!isPresent){
            Console.WriteLine("The name is not present in array");
          
        }
        foreach(string i in names){
            if(i==searchName){
                isPresent=true;
                break;
            }else{
                isPresent=false;
            }
        }
        if(isPresent){
            Console.WriteLine("The name is present in array");
          
        }else{
            Console.WriteLine("The name is not present in array");
        }
    }
}