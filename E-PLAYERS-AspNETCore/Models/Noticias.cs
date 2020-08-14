using System;
using System.Collections.Generic;
using System.IO;
using EPlayers.Interfaces;

namespace EPlayers.Models
{
    public class Noticias : EplayersBase , INoticias
    {
        public int IdNoticia { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Imagem { get; set; }
        public const string PATH = "DataBase/noticias.csv";

      
        /// <summary>
        /// Cria arquivo CSV para as noticias que serão instanciadas
        /// </summary>
        public Noticias(){
            CreateFolderAndFile(PATH);
        }

        /// <summary>
        /// Adiciona noticias devidamente instanciadas ao arquivo CSV
        /// </summary>
        /// <param name="e">termo que indica a noticia que será adicionada</param>
        public void Create(Noticias news)
        {
            string[] linha = { Prepare(news) };
            File.AppendAllLines(PATH, linha);
        }

        /// <summary>
        /// Método de apoio para a organização das informações nas linhas de CSV
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private string Prepare(Noticias news){
            return $"{news.IdNoticia};{news.Titulo};{news.Texto};{news.Imagem}";
        }

        /// <summary>
        /// Método que lê as informações do arquivo PATH
        /// </summary>
        /// <returns></returns>
        public List<Noticias> ReadAll()
        {
           List<Noticias> news = new List<Noticias>();
           string[] linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Noticias noticia = new Noticias();
                noticia.IdNoticia = Int32.Parse(linha[0]);
                noticia.Titulo = linha[1];
                noticia.Texto = linha[2];
                noticia.Imagem = linha[3];


                news.Add(noticia);
            }
            return news;
        }


        /// <summary>
        /// Método que remove e reescreve o arquivo CSV ,  com uma nova informação inserida
        /// </summary>
        /// <param name="e">Nova instância de Noticia nova que será adicionada</param>
         public void Update(Noticias news)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == news.IdNoticia.ToString());
            linhas.Add( Prepare(news) );
            RewriteCSV(PATH, linhas);
        }
        
        /// <summary>
        /// Remove informação do arquivo CSV
        /// </summary>
        /// <param name="id">indica o id da equipe que será removida</param>
        public void Delete(int id)
        {
           List<string> linhas = ReadAllLinesCSV(PATH);
           linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
           RewriteCSV(PATH, linhas);
        }
    }
}