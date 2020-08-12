using System;
using System.Collections.Generic;

namespace Aula24_ObjetoArgumento
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto produto){
            carrinho.Add(produto);
        }

         public void RemoverProduto(Produto produto){
             carrinho.Remove(produto);
         }

         public void MostrarProdutos(){
             foreach(Produto prod in carrinho){
                 Console.ForegroundColor = ConsoleColor.DarkBlue;
                 System.Console.WriteLine($"{prod.Nome} , R${prod.Preco}");
                 Console.ResetColor();
             }
         }

         public void AlterarProduto(int codigo , Produto novoproduto){
             Console.Clear();
             carrinho.Find(p => p.Codigo == codigo).Nome = novoproduto.Nome ;
             carrinho.Find(p => p.Codigo == codigo).Preco =  novoproduto.Preco ; 
         }

         public void MostralTotal()
         {
             if(carrinho != null)
            
             {
             foreach(Produto produto in carrinho)
             {    
             ValorTotal += produto.Preco;
             }

             Console.ForegroundColor = ConsoleColor.Green;
             System.Console.WriteLine($"O valor total da compra é de R$ {ValorTotal}");
             Console.ResetColor();
             }


             else{
                 Console.ForegroundColor = ConsoleColor.Red;
                 System.Console.WriteLine("O seu carrinho está vazio");
                 Console.ResetColor();
             }
             
         }   

         

    }

   
}