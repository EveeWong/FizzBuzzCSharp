using System;

namespace FizzBuzzC_
{
    class Program
    {
        static void Main(string[] args)
            {
            for (int i = 1; i <= 100; i++) {      
                 if (i % 3 == 0) {
                 Console.WriteLine(PrintFizz());          
                 } else { 
                 Console.WriteLine(i);
                 }             
            }   
            }
        
        static String PrintFizz() 
            {
         return "Fizz";
        }
    }

}
