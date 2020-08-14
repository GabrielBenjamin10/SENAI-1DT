using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {

            Lampada lampada = new Lampada();
            Console.WriteLine(" Qual o modelo (LED ou FLuorescente)? ");            
            lampada.modelo = Console.ReadLine();
            Console.WriteLine("Qual a cor?");
            lampada.cor = Console.ReadLine();
            Console.WriteLine("A Lâmpada de "+ lampada.modelo );
            Console.WriteLine("Cor " + lampada.cor);
            Console.WriteLine(lampada.Acender());
            
          






        }
    }
}
