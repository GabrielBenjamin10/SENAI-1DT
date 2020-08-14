namespace ProjetoWppConsole
{
    public class Contato
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public Contato(string nome , string telefone){
            this.Nome = nome;
            this.Telefone = telefone;
        }
    }
}