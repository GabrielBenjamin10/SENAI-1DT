using System;
using System.Threading;

namespace Ifood
{
    public class Pedido
    {
        public string Itens {get; set;}
        public Cliente Cliente {get; set;}
        public string FormaDePGTO {get; set;}
        public bool PedidoPago {get; set;}        
        public Restaurante Restaurante {get; set;}

        public DateTime Hora {get; set;}


    
        public string EntregarPedido(){
           Hora = DateTime.Now ; 
           Thread.Sleep(5000);
           string retorno = "O pedido está sendo preparado\n";
          
           retorno += $"O pedido de {Cliente.Nome} saiu para entrega....\n"; 
          
           retorno +=  $"O pedido foi entregue as {Hora} ";
           return retorno ; 
        }


    }     
}     
