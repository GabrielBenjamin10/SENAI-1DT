using System;

namespace ExercicioCartao
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao cartao = new Cartao();
            
            MasterCard master = new MasterCard();
            Console.WriteLine(master.AprovarCompra());
            master.ComprarComDescontoMaster(100f);
        }
    }
}
