using System.Collections.Generic;
using MVCconsolePOO.Model;
using MVCconsolePOO.View;

namespace MVCconsolePOO.Controller
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar(){

            List<Produto> lista = produtoModel.Ler();
            produtoView.MostrarNoConsole(lista);
        }

        public void Buscar(string termo){
            List<Produto> lista = produtoModel.Ler().FindAll(p => p.Preco == float.Parse(termo));
            produtoView.MostrarNoConsole(lista);
        }
    }
}