using System;
using System.Collections.Generic;

namespace Aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando Lista
            List<Cartao> cartoes = new List<Cartao>();
            //Adicionando novos cartões
            cartoes.Add(new Cartao("Gabriel","005748839","VISA","10/10/2025","612"));
            cartoes.Add(new Cartao("Gabriel","954958478","MASTERCARD","10/10/2024","753"));
            
            //Método de instância tradicional e adicionamos o objeto instanciado
            Cartao elo = new Cartao("Gabriel","00545548","ELO","10/10/2026","821");
            cartoes.Add(elo);

            //exibindo lista
            foreach (Cartao cartao in cartoes)
            {
                System.Console.WriteLine($"{cartao.Titular} , {cartao.Bandeira} , {cartao.Numero} , {cartao.Vencimento} , {cartao.CVV}");
            }

            // Contagem iniciando em 0 ,  sendo assim o cartão removido será o Elo, na posição 2 do array
            cartoes.RemoveAt(2);

            //expressão lambda , metodo RemoveAll. Estabeleci um filtro de procura pelo atributo Bandeira
            cartoes.RemoveAll(c => c.Bandeira == "MASTERCARD");

            System.Console.WriteLine("\n LISTA DE CARTOES ALTERADA:\n");
               //exibindo lista alterada ( Deve conter somente o cartão VISA)
            foreach (Cartao cartao in cartoes)
            {
                System.Console.WriteLine($"{cartao.Titular} , {cartao.Bandeira} , {cartao.Numero} , {cartao.Vencimento} , {cartao.CVV}");
            }
            

            
        }
    }
}
