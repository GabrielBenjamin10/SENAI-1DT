using System;
using System.Collections.Generic;
using System.Threading;

namespace Aula29Excel
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.Codigo = 1;
            p.Nome = "Geladeira";
            p.Preco = 3000f;

            Produto p2 = new Produto();
            p2.Codigo = 2;
            p2.Nome = "Playstation";
            p2.Preco = 4600f;

            Produto p3 = new Produto();
            p3.Codigo = 3;
            p3.Nome = "Xbox";
            p3.Preco = 5000f;
           
            p.Inserir(p);
            p.Inserir(p2);
            p.Inserir(p3);

            p.Remover("Geladeira");
            List<Produto> Lista  = p.Ler();
            foreach(Produto item in Lista )
            {
                Console.ForegroundColor =  ConsoleColor.DarkCyan;
                System.Console.WriteLine($"R$ {item.Preco}  {item.Nome}");
                Console.ResetColor();
            }
            Thread.Sleep(5000);
            Console.Clear();           
        }
    }
}