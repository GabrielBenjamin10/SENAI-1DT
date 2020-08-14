using System.IO;

namespace Aula27_CriarExcel
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }

        //PATH = Arquivo CSV 
        private const string PATH = "Database/Produto.csv";

        public Produto(){

            //Cria um diretorio para armazenar o csv PATH

            string pasta = PATH.Split('/')[0];
            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }

            //Cria produto caso não exista

            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }

        public void InserirProduto(Produto p){
            var linha = new string [] { p.PreparaLinhaCSV(p) };
            File.AppendAllLines (PATH ,  linha);
        }

        private string PreparaLinhaCSV (Produto produto){
            return $"codigo={produto.Codigo};nome={produto.Nome};preco={produto.Preco};";
        }
        
        
    }
}