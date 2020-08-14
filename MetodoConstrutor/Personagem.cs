namespace MetodoConstrutor
{
    public class Personagem
    {
        public int Vida { get; set; }
        public int Municao { get; set; }
        public string ArmaBranca { get; set; }

        public Personagem(){

        }

        public Personagem(int vida , int municao , string armabranca){
            Vida = vida;
            Municao = municao;
            ArmaBranca = armabranca;
        }
    }
} 