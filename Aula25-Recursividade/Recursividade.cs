namespace Aula25_Recursividade
{
    public class Recursividade
    {
        public void GerarFibonacci(int n1 , int n2 , int vezes){
            if(vezes >=0){
                System.Console.WriteLine(n1);
            }

            GerarFibonacci(n2, n1+n2 , vezes - 1);
        }


          public int Fatorial(int n1){
              //primeira condiciona que caso n1 == 1 seu retorno será 1 ou seja, esse é o limite de parada
            if(n1 == 1){
                return 1;
            }
            // a operação ocorre no else, onde dizemos ao program que ele deve subtrair 1 unidade de 
            //n1 e multiplica-lo pelo mesmo até que n1 retorne 1 (condição estabelecida em if)
            
            else{
                return n1 * Fatorial(n1-1);
            }
   
        }  
    }

    
}
