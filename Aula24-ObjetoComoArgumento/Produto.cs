namespace Aula24_ObjetoArgumento
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        public Produto(int codigo,string nome, float preco){
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}