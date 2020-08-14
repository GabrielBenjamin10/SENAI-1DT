using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MVCconsolePOO.Model
{
    public class Produto
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

                private string Separar(string _coluna)
        {
            // 0      1
            // nome = Gibson
            return _coluna.Split("=")[1];
        }
    }
}