using System;
namespace Ifood
{
    public class Restaurante
    {
        public string NomeFantasia {get;set;}
        
        public string Endereco { get;set; }

        public string MostrarDados(){
           
        return ($"A {NomeFantasia} está localizada na {Endereco}\n");

        }

        public Restaurante( string _nomeFantasia, string _endereco ){
            
            this.NomeFantasia = _nomeFantasia;
            this.Endereco = _endereco;
            
        }
        

        
    }
}