using System;
using System.Threading;

namespace Aula24_ObjetoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
             Carrinho  carrinho = new Carrinho();

            Produto p1 = new Produto(1 , "GTA V" , 50f);
            Produto p2 = new Produto(2 , "The Last of Us PART II", 249f);
            Produto p3 = new Produto(3 , "FIFA 21", 300f);

           

            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            
            carrinho.MostrarProdutos();
            carrinho.RemoverProduto(p1);
            
            Thread.Sleep(4000);
            

            Produto prodAterado = new Produto(1 ,"GTA VI" , 400f);
            carrinho.AlterarProduto(3 , prodAterado);
            carrinho.MostrarProdutos();
            carrinho.MostralTotal();
            
                


            
            

 
        }
    }
}
