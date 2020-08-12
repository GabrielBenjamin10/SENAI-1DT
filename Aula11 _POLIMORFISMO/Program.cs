using System;

namespace Aula11OverLoad
{
    class Program
    {
        static void Main(string[] args)
        {
           Player goku = new Player();
           System.Console.WriteLine(goku.Atacar()); 
           System.Console.WriteLine(goku.Atacar(8000));
           System.Console.WriteLine(goku.Atacar(3000,50));
           System.Console.WriteLine(goku.Atacar("10"));
        }
    }
}
