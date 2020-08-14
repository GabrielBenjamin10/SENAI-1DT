using System;
using System.Collections.Generic;
using MVCconsolePOO.Model;

namespace MVCconsolePOO.View
{
    public class ProdutoView
    {
        public void MostrarNoConsole(List<Produto> Lista){
            
            foreach(Produto produto in Lista){
                Console.WriteLine($"Preço: R${produto.Preco} -- Nome: {produto.Nome} ");
            }
        }
    }
}