using System;
using System.Threading;
using MVCconsolePOO.Controller;

namespace MVCconsolePOO
{
    class Program
    {
        static void Main(string[] args)
        {
           ProdutoController produtos = new ProdutoController();
           produtos.Listar();
           Thread.Sleep(4000);
           produtos.Buscar("6000");
        }
    }
}
