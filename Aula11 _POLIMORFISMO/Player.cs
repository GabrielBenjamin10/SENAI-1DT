namespace Aula11OverLoad
{
    public class Player
    {
        public string Atacar(){
            return "Você atacou!!";
        }

            public string Atacar(int poder){
            return "Você atacou com um poder de mais de " + poder;
        }

            public string Atacar(int poder, int vida){
            return $"Você recebeu um dano crítico sua vida está em {vida}% e seu poder menos de {poder}";
        }

         public string Atacar(string life){
          
           if(life == "0"){
               return "Você perdeu a luta";
           }

           else{
               return "Você venceu a luta";
           }
        }

            
    }
}