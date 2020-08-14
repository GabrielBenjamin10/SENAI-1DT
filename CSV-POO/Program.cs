using System;

namespace Aula27_CriarExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.Codigo =1;
            p.Nome="Geladeira";
            p.Preco=3000f;
            
            p.InserirProduto(p);
        }
    }
}
