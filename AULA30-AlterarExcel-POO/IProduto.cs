using System.Collections.Generic;

namespace AULA30AlterarExcelPOO
{
    public interface IProduto
    {
         List<Produto> Ler();

         void Cadastrar(Produto prod);

         void Remover (string termo);

         void Alterar(Produto _produtoAlterado);
    }
}