namespace ExercicioCartao
{
    public class Cartao
    {
        public string numero { get; set; }
        public string bandeira { get; set; }
        
        private string token = "1232u4832ss";

        protected int cvv { get; set; }

        public string AprovarCompra(){
            return "COMPRA APROVADA";
        }

        private bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }

        protected bool ValidarCompra(){
            return true;
        }




    }
}