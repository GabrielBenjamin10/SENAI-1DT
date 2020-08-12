using System.Threading ;  
namespace Aula19

{
    public class IngressoVip : Ingresso
    {
        public float ValorAdicional { get; set; }

        public void MostrarValorVip()
        {
            Thread.Sleep(3000);
            float resultado = Valor + ValorAdicional;
            System.Console.WriteLine($"Valor do ingresso adicional é R$ {resultado}");
        }
    }
}