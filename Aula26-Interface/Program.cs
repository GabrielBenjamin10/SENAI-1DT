using System;
using System.Threading;

namespace Aula26_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();

            Product p1 = new Product(1 ,"Playstation 5" , 500f );
            Product p2 = new Product(2 ,"Xbox Series X" , 550f );
            Product p3 = new Product(3 ,"Nintendo Switch" , 300f );

            cart.AddProduct(p1);
            cart.AddProduct(p2);
            cart.AddProduct(p3);

            cart.Read();
            Thread.Sleep(4000);
            cart.RemoveProduct(p2);
            Console.Clear();

            
            Product newProduct = new Product(4 , "PC" , 1000f);            
            cart.UpdateProduct(3 , newProduct );
            cart.Loading();
            cart.Read();
            cart.ShowTotal();


        }
    }
}
