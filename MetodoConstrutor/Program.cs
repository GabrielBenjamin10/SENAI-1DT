using System;

namespace MetodoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
           Personagem Joel = new Personagem(100, 50 , "Pé de cabra");
           Personagem Elie = new Personagem(50 , 0, "Faca");
           System.Console.WriteLine($"Joel's Stats:\n ----\n Vida:{Joel.Vida}\n ----\n Munição:{Joel.Municao} \n ---- \n Arma Branca:{Joel.ArmaBranca} \n ");
           
           System.Console.WriteLine($"Elie's Stats:\n ----\n Vida:{Elie.Vida}\n ----\n Munição:{Elie.Municao} \n ---- \n Arma Branca:{Elie.ArmaBranca}  ");
        }
    }
}
