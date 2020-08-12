
using System.Threading;
namespace Aula19

{
    public class Ingresso
    {
        public float Valor { get; set; }

        public void ImprimirValor(){
            Thread.Sleep(3000);
            System.Console.WriteLine($"Valor do ingresso comum é R$ {Valor}.");
        } 
    }
}