using System;

namespace ExercicioCartao
{
    public class MasterCard : Cartao
    {
        public int parcelas { get; set; } = 3;
        
        public void ComprarComDescontoMaster(float desconto){
            Console.WriteLine($"Compra realizada em {parcelas} parcelas, com R${desconto} de desconto ");
        }
    }
    }
