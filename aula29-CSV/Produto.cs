using System.IO;
using System;
using System.Collections.Generic;

public class Produto
    {
        
        public int Codigo {get;set;}
        public string Nome {get;set;}
        public float Preco {get;set;}

        private const string PATH = "Database/Produto.csv";

        /// <summary>
        /// Ao instanciarmos um Produto e rodarmos o programa , criamos uma pasta DATABASE com seu arquivo Excel 
        /// </summary>
        public Produto()
        {
                       
            string pasta = PATH.Split('/')[0]; 
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }        
        }

        /// <summary>
        /// Inserir produto na lista Excel
        /// </summary>
        /// <param name="p"></param>
        public void Inserir(Produto p){
            var linha = new string [] {p.PrepararLinhaCSV(p)};
            File.AppendAllLines(PATH, linha);
        }        
       
      /// <summary>
      /// ira ler os produtos listados, criar array de linha, separar as linhas em split, para facilitar leitura
      /// </summary>
      ///        /// <returns></returns>
        public List<Produto> Ler()
        {     
        // Lista de Produtos
            List<Produto> produtos = new List<Produto>();

            //arry de linhas 
            string[] linhas = File.ReadAllLines(PATH);

            //separar cada linha com split
            foreach(string linha in linhas)
            {
            
            string[] dado = linha.Split(";");
            //criar instancia para add na lista
            Produto x = new Produto();
            x.Codigo = Int32.Parse(separar(dado[0]));
            x.Nome = separar(dado[1]);
            x.Preco = float.Parse(separar(dado[2]));
            produtos.Add(x);
            }            
            return produtos;
        }

        public void Remover(string termo){
            //Lista de backup de nosso arquivo CSV
            List<string> linhas = new List<string>();
            
            using(StreamReader arquivo = new StreamReader(PATH))
            {
               string linha;
               while((linha = arquivo.ReadLine())!=null)
               {
                   linhas.Add(linha);
               }
            }

            // Nesse comando estamos removendo todos os atributos que o termo solicitado contem
            // EX: p2 = 2;Playstation;4600F - Todo esse bloco será removido de nosso arquivo CSV
            linhas.RemoveAll(r => r.Contains(termo));

            //Reescreveremos nosso arquivo CSV novamente, agora sem os itens removidos
            using(StreamWriter output = new StreamWriter(PATH))
            {
                foreach(string line in linhas){
                    output.Write(line + "\n");
                }
            }
        }

        //CRIADO PARA OTIMIZAR O TEMPO 
       /// <summary>
       /// criado para otimizar o tempo na hora de instanciar
       /// </summary>
       /// <param name="_coluna"></param>
       /// <returns></returns>
        
        /// <summary>
        /// Separar as linhas da tabela com o "="
        /// </summary>
        /// <param name="_coluna"></param>
        /// <returns></returns>
        private string separar(string _coluna)
        {
            return _coluna.Split("=")[1];
        }

        /// <summary>
        /// Organizar a linha de forma correta 
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        private string PrepararLinhaCSV(Produto produto){

            return $"Cod={produto.Codigo};Nome={produto.Nome};Preco ={produto.Preco}";
        }

               

        /// <summary>
        /// Realiza busca de preço dos produtos listados (DESAFIO)
        /// </summary>
        /// <param name="_nomebusca"></param>
        public List<Produto> BuscarProduto(string _nomebusca){
          return Ler().FindAll(n => n.Nome == _nomebusca);
        }

       
    }