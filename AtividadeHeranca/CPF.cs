namespace Aula06Heranca
{
    //Herança chamada da super classe Pessoa, com (espaço):nomedaclassepai
    public class CPF : Pessoa
    {
         public string cpf;
        public string rg;

        public bool ValidarCPF()
        {
            if(cpf != null){
                return true;
            }

            return false;
        }

        public string MostrarCPF(){
            if(cpf != null){
                return "o cpf a seguir é valido " + cpf;    
            }

            return  cpf;
        }
    

    
    }
}