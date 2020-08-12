namespace Calculadora
{
    public class Calculadora
    {
        public float n1 { get; set; }
        public float n2 { get; set; }
        public float resultado { get; set; }

        public string operador { get; set; }

        public void Somar(){
            resultado = 0;
            resultado = n1 + n2;
        }    

          public void Subtrair(){
            resultado = 0;
            resultado = n1 - n2;
        } 

         public void Dividir(){
            resultado = 0;
            resultado = n1 / n2;
        }            

            public void Multiplicar(){
            resultado = 0;
            resultado = n1 * n2;
        } 

    }
}