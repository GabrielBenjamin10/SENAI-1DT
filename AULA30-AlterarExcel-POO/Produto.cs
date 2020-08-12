using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AULA30AlterarExcelPOO
{
    public class Produto : IProduto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/produto.csv";


        
        /// <summary>
        /// Criação de arquivo e diretório CSV
        /// </summary>
        public Produto()
        {
            
            string pasta = PATH.Split('/')[0];

            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        /// <summary>
        /// Cadastra um produto
        /// </summary>
        /// <param name="prod">Objeto Produto</param>
        
        // Inicio do CRUD
        
        /// <summary>
        /// Cadastra os produtos na lista
        /// </summary>
        /// <param name="prod"></param>
        public void Cadastrar(Produto prod)
        {
            var linha = new string[] { PrepararLinha(prod) };
            File.AppendAllLines(PATH, linha);
        }
      
      /// <summary>
      /// ira ler os produtos listados, criar array de linha, separar as linhas em split, para facilitar leitura
      /// </summary>
      ///        /// <returns></returns> 
        public List<Produto> Ler()
        {
            // Criamos uma lista que servirá como nosso retorno
            List<Produto> produtos = new List<Produto>();

            // Lemos o arquivo e transformamos em um array de linhas
            // [0] = codigo=1;nome=Gibson;preco=7500
            // [1] = codigo=1;nome=Fender;preco=7500 
            string[] linhas = File.ReadAllLines(PATH);

            foreach(string linha in linhas){
                
                // Separamos os dados de cada linha com Split
                // [0] = codigo=1
                // [1] = nome=Gibson
                // [2] = preco=7500
                string[] dado = linha.Split(";");

                // Criamos instâncias de produtos para serem colocados na lista
                Produto p   = new Produto();
                p.Codigo    = Int32.Parse( Separar(dado[0]) );
                p.Nome      = Separar(dado[1]);
                p.Preco     = float.Parse( Separar(dado[2]) );

                produtos.Add(p);
            }

            produtos = produtos.OrderBy(y => y.Nome).ToList();
            return produtos; 
        }

        /// <summary>
        /// Altera um produto
        /// </summary>
        /// <param name="_produtoAlterado">Objeto de Produto</param>
             public void Alterar(Produto _produtoAlterado){

            // Criamos uma lista que servirá como uma espécie de backup para as linhas do csv
            List<string> linhas = new List<string>();

            // Utilizamos a bliblioteca StreamReader para ler nosso .csv
            using(StreamReader arquivo = new StreamReader(PATH))
            {
                string linha;
                while((linha = arquivo.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            }
            // codigo=2;nome=Ibanez;preco=7500
            // linhas.RemoveAll(z => z.Split(";")[0].Contains(_produtoAlterado.Codigo.ToString()));
            
            // codigo= 2; nome=Ibanez;preco=7500
            linhas.RemoveAll(z => z.Split(";")[0].Split("=")[1] == _produtoAlterado.Codigo.ToString());

            // Adicionamos a linha alterada na lista de backup
            linhas.Add( PrepararLinha(_produtoAlterado) );

            // Reescrevemos nosso csv do zero
            ReescreverCSV(linhas);         
        }

        /// <summary>
        /// Remove uma ou mais linhas que contenham o termo
        /// </summary>
        /// <param name="_termo">termo para ser buscado</param>
        public void Remover(string _termo){

            // Criamos uma lista que servirá como uma espécie de backup para as linhas do csv
            List<string> linhas = new List<string>();

            // Utilizamos a bliblioteca StreamReader para ler nosso .csv
            using(StreamReader arquivo = new StreamReader(PATH))
            {
                string linha;
                while((linha = arquivo.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            }
            
            // Nesse comando estamos removendo todos os atributos que o termo solicitado contem
            // EX: p2 = 2;Playstation;4600F - Todo esse bloco será removido de nosso arquivo CSV
            linhas.RemoveAll(l => l.Contains(_termo));

            // Reescrevemos nosso csv do zero ,  sem o item removido
            ReescreverCSV(linhas);
        }

        // Final do CRUD


        // Métodos de apoio
        private void ReescreverCSV(List<string> lines){
            // Reescrevemos nosso csv do zero
            using(StreamWriter output = new StreamWriter(PATH))
            {
                foreach(string ln in lines)
                {
                    output.Write(ln + "\n");
                }
            }   
        }

        public List<Produto> Filtrar(string _nome)
        {
            return Ler().FindAll(x => x.Nome == _nome);
        }

        private string Separar(string _coluna)
        {
            // 0      1
            // nome = Gibson
            return _coluna.Split("=")[1];
        }

        // 1;Celular;600
        private string PrepararLinha(Produto p)
        {
            return $"codigo={p.Codigo};nome={p.Nome};preco={p.Preco}";
        }

    }
}