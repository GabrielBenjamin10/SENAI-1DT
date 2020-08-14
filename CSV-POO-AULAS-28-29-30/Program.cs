using System;
using System.Collections.Generic;
using System.Threading;

namespace Aula28Excel
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(1 , "Geladeira" ,  3000f);
            Produto p2 = new Produto(2 , "Fogão" , 5000f);
            Produto p3 = new Produto(3 , "Microondas" , 1000f);
            Produto p4 = new Produto(4 , "Mesa" , 300f);
            Produto p5 = new Produto(5 , "Playstation 5" , 4600f);
            Produto p6 = new Produto(6 , "Xbox Series X" , 5000f);
            
            
           // p.Inserir(p);
           // p.Inserir(p2);
           // p.Inserir(p3);
           //p.Inserir(p4);
           // p.Inserir(p5);
           // p.Inserir(p6);
            

            List<Produto> Lista  = p.Ler();
            
            
            foreach(Produto item in Lista )
            {
                Console.ForegroundColor =  ConsoleColor.DarkCyan;
                System.Console.WriteLine($"R$ {item.Preco}  {item.Nome}");
                Console.ResetColor();
            }
            Thread.Sleep(4000);
            Console.Clear();

            System.Console.WriteLine("Digite o nome do produto que deseja buscar o preço...");
            p.BuscarProduto(Console.ReadLine());
            
        }
    }
}