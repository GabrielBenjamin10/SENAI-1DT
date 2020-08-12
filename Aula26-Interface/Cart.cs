using System;
using System.Collections.Generic;
using System.Threading;

namespace Aula26_Interface
{
    public class Cart : ICart
    {

        public float TotalValue {get; set;} 

        List<Product> cart = new List<Product>();

        public void AddProduct(Product product)
        {
            cart.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            cart.Remove(product);
        }

        public void Read()
        {
            foreach(Product p in cart){
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                System.Console.WriteLine($"Product:{p.Name} Price:$ {p.Price.ToString("n2")}");
                Console.ResetColor();
            }
        }

        public void ShowTotal()
        {
            if(cart != null){
                foreach (Product p in cart){
                TotalValue +=p.Price;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"The total value is : $ {TotalValue.ToString("n2")}");
            Console.ResetColor();
            }
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Your cart is empty!");
                Console.ResetColor();
            }
        }

        public void UpdateProduct(int code , Product newProduct)
        {
            cart.Find(p => p.Code == code).Name = newProduct.Name;
            cart.Find(p => p.Code == code).Price = newProduct.Price;

        }

        public void Loading(){
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("UPDATING..."); 
            Console.ResetColor();
            Thread.Sleep(4000);
            Console.Clear();
        }
    }
}