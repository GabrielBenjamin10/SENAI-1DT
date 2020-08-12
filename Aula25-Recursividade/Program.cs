using System;

namespace Aula25_Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade rec = new Recursividade(); 
            //rec.GerarFibonacci(0,1,10);
            System.Console.WriteLine(rec.Fatorial(10));  
            
            
        }
    }
}
