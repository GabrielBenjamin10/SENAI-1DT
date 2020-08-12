using System;
namespace Aula18

{
    public class Jogador
    {
        //posição
        //idade
        //nascimento
        //nome
        //peso
        //altura
        


        public string Nome { get; set; } = "Ribamar";
        public int Idade { get; set; }
        public string Posicao { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
        public string Nacionalidade {get;set;}
        public DateTime Nascimento {get;set;}


        public int CalcularIdade(){
            int AnoAtual = Int32.Parse(DateTime.Now.ToString().Split ("/") [2].Split (" ") [0]);
            int DataNascimento = Int32.Parse(Nascimento.ToString().Split("/")[2].Split(" ") [0]  );

            Idade = AnoAtual - DataNascimento;

            return Idade;
            
        
        }
        
        //pq tem que colocar [0] dps no split     
        //16 = [0], 06 = [1], 2020 = [2]
        //16/06/2020
        
        //o [ significa qual termo voce explodiu]    
         
        //Atacante = 35
        //DEFENSOR = 40 
        //Meio-Campista = 38
        //eu nao sei oq ue isso vamo la kai eu te ajudo se eu souber também
      
        public string VerificarAposentadoria(){
            
            string Retorno = "";

            if (Idade >= 35 && Posicao == "Atacante")
            {
                Retorno = "O Atacante pode se aposentar";

            }else if (Idade >= 38 && Posicao == "Meio Campista"){

                Retorno = "O Meio Campista pode se aposentar";

            }else if (Idade >= 40 && Posicao == "Defensor"){

                Retorno = "O Defensor pode se aposentar"; 

            }else{

                Retorno = "O jogador não atingiu a idade suficiente para se aposentar!";
            }
            return Retorno; 
        }


        public void MostrarDados(){
            System.Console.WriteLine($"Nome: {Nome}, Posição: {Posicao}, Nascimento: {Nascimento}");
        }        

    } 

}