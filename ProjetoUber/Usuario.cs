namespace ProjetoUber
{
    public class Usuario
    {
        
        // Propriedade resumida
        public string Nome { get; set; }

        // Propriedade completa
        private int idade = 0;
        public int Idade
        {
            get { return idade; }
            set { 
                if(idade > 0){
                    idade = value;
                }  
            }
        }

        public string Foto { get; set; }
        private string login = "gabrielbenjamin@gmail.com";
        private string senha = "987654321";

        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; } 
        public string TipoAcesso { get; set; }

        /// <summary>
        /// Faz Login no sistema
        /// </summary>
        /// <param name="login">email do usuario</param>
        /// <param name="senha">senha do usuario</param>
        /// <returns>Salva o token e retorna se o login foi aprovado ou nao</returns>
        public bool Login(string login, string senha){

            if( this.login == login && this.senha == senha ){
                TokenLogin = "ijvrinvrnvinvrivnrivnrivnrivn";
                return true;
            }

            return false;
        }

        /// <summary>
        /// Apaga o token do usuario
        /// </summary>
        public void Logout(){
            TokenLogin = "";
        }


    }
}