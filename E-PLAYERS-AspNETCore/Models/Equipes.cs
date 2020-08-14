using System;
using System.Collections.Generic;
using System.IO;
using EPlayers.Interfaces;

namespace EPlayers.Models
{
    public class Equipes : EplayersBase , IEquipes
    {
        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public const string PATH = "DataBase/equipes.csv";

        /// <summary>
        /// Cria arquivo CSV para as equipes que serão instanciadas
        /// </summary>
        public Equipes(){
            CreateFolderAndFile(PATH);
        }

        /// <summary>
        /// Adiciona equipes ao arquivo CSV
        /// </summary>
        /// <param name="e">termo que indica a equipe que será adicionada</param>
        public void Create(Equipes e)
        {
            string[] linha = { Prepare(e) };
            File.AppendAllLines(PATH, linha);
        }

        /// <summary>
        /// Método de apoio para a organização das informações nas linhas de CSV
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private string Prepare(Equipes e){
            return $"{e.IdEquipe};{e.Nome};{e.Imagem}";
        }

        /// <summary>
        /// Método que lê as informações do arquivo PATH
        /// </summary>
        /// <returns></returns>
        public List<Equipes> ReadAll()
        {
           List<Equipes> equipes = new List<Equipes>();
           string[] linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Equipes equipe = new Equipes();
                equipe.IdEquipe = Int32.Parse(linha[0]);
                equipe.Nome = linha[1];
                equipe.Imagem = linha[2];

                equipes.Add(equipe);
            }
            return equipes;
        }


        /// <summary>
        /// Método que remove e reescreve o arquivo CSV ,  com uma nova informação inserida
        /// </summary>
        /// <param name="e">Equipe nova que será adicionada</param>
         public void Update(Equipes e)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == e.IdEquipe.ToString());
            linhas.Add( Prepare(e) );
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