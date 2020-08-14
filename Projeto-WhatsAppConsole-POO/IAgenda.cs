using System.Collections.Generic;

namespace ProjetoWppConsole
{
    public interface IAgenda
    {
         void Cadastrar(Contato contato);
         void Excluir(string contato);
         List<Contato> Ler();

    }
}