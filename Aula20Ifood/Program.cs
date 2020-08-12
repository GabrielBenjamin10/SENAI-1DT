using System;

namespace Ifood
{
    class Program
    {
        static void Main(string[] args)
        {
           Restaurante Cantina = new Restaurante("Cantina do Zé " , "Rua Maracatu , 192");
           System.Console.WriteLine(Cantina.MostrarDados());

           Cliente Gil = new Cliente("Gil" , "Rua Satelite , 176");
           System.Console.WriteLine(Gil.MostrarDados());

           Pedido pedido = new Pedido();
            pedido.Cliente = Gil; 
            System.Console.WriteLine(pedido.EntregarPedido()); 
            
        }                
    }
}