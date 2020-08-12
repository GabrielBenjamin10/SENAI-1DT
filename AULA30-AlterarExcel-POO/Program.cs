using System;
using System.Collections.Generic;
using System.Threading;

namespace AULA30AlterarExcelPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome = "PS5";
            p1.Preco = 4600f;

            p1.Cadastrar(p1);
            p1.Remover("PS5");

            Produto p2 = new Produto();
            p2.Codigo = 2;
            p2.Nome = "XBOX";
            p2.Preco = 5000f;
            p2.Cadastrar(p2);

            Produto p3 = new Produto();
            p3.Codigo = 3;
            p3.Nome = "TV";
            p3.Preco = 8000f;
            p3.Cadastrar(p3);

            
            Produto alterado = new Produto();
            alterado.Codigo = 2;
            alterado.Nome = "PC";
            alterado.Preco = 6000f;

            p1.Alterar(alterado);
            
            List<Produto> lista = p1.Ler();

            foreach(Produto item in lista)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
                Console.ResetColor();
            }

            Thread.Sleep(4000);
            Console.Clear();

          

        }
    }
}
