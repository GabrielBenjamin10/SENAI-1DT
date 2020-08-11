    public class celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;


/// <summary>
/// Liga o celular
/// </summary>
/// <returns>texto de celular ligado</returns>
        public string Ligar(){
              ligado =true;  
              return "Celular Ligado";  
            }
       
    /// <summary>
    /// Enviar Mensagem
    /// </summary>
    /// <returns>texto para enviar mensagem</returns>
       public string EnviarMsg(){
               return "enviando mensagem";
       }


    /// <summary>
    /// Ligar para alguém
    /// </summary>
    /// <returns>texto ligando para</returns>
        public string Ligando(){
               return "Ligando para...";
           }
           
       

       /// <summary>
       /// Celular Desligado
       /// </summary>
       /// <returns>texto de celular desligado</returns>
       public string Desligar(){
           ligado = false;
            return "Celular Desligado";
       }
       
       }
            
