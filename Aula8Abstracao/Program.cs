using System;

namespace Aula08Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Cartao 1

            CartaoCredito visa = new CartaoCredito();
            visa.limite = 10000f;

            Console.WriteLine("Deseja acrescentar quanto no limite?");
            float acres = float.Parse( Console.ReadLine() );
            
            visa.AumentarLimite(acres);
            Console.WriteLine("Novo limite: R$ "+visa.limite);

            System.Console.WriteLine("Digite a data do pagamento:");
            visa.data = DateTime.Parse( Console.ReadLine() );
            
            System.Console.WriteLine("Data: " + visa.data);

            Console.WriteLine("Deseja cancelar o pagamento?");
            Console.WriteLine(visa.Cancelar(Console.ReadLine()));

        }
    }
}
