namespace Ifood
{
    public class Cliente
    {
        public string Nome {get; set;}
        public string EnderecoAtual {get; set;}

        public Cliente(string _nome, string _enderecoAtual){
             
            this.Nome = _nome;
            this.EnderecoAtual = _enderecoAtual; 

        }

        public string MostrarDados(){

           return ($"O Sr {Nome} está localizada em {EnderecoAtual}\n");

        }
    
        
    } 
}