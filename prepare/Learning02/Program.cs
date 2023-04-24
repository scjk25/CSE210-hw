using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!"); 
        Learning02.Program program = new Learning02.Program();
        program.AnotherFunction();
    }
} 


namespace Learning02
{   class Program
    {
        public void AnotherFunction()
        {
            Console.WriteLine("Now I am Writeing another function.");
        }
    }   
    
}