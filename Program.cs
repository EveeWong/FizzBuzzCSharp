using System;

namespace FizzBuzzC_
{
    class Program
    {
        static void Main(string[] args)
            {
            for (int i = 1; i <= 100; i++) {      
                 if (i % 3 == 0 && i % 5 == 0) {
                 Console.WriteLine(PrintFizz()+PrintBuzz());          
                 } else if (i % 3 == 0) {
                 Console.WriteLine(PrintFizz());
                 } else if (i % 5 ==0) {
                 Console.WriteLine(PrintBuzz());    
                 } else {
                 Console.WriteLine(i);
                 }             
            }   
            }
        
        static String PrintFizz() 
            {
            return "Fizz";
            }

        static String PrintBuzz()
            {
            return "Buzz";
            }
    }

}
