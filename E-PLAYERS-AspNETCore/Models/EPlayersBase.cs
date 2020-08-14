using System.Collections.Generic;
using System.IO;

namespace EPlayers
{
   public class EplayersBase
    {     

        /// <summary>
        /// Método responsável por criar arquivo e diretório CSV
        /// </summary>
        /// <param name="_path"></param>
        public void CreateFolderAndFile(string _path){

            string folder   = _path.Split("/")[0];
            string file     = _path.Split("/")[1];

            if(!Directory.Exists(folder)){
                Directory.CreateDirectory(folder);
            }

            if(!File.Exists(_path)){
                File.Create(_path).Close();
            }
        }

        /// <summary>
        /// Lê novamente o arquivo CSV, fazendo uma espécie de lista BACKUP
        /// </summary>
        /// <param name="PATH"></param>
        /// <returns></returns>
        public List<string> ReadAllLinesCSV(string PATH){
            
            List<string> linhas = new List<string>();
            using(StreamReader file = new StreamReader(PATH))
            {
                string linha;
                while((linha = file.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            }
            return linhas;
        }

        /// <summary>
        /// Reescreve o arquivo CSV
        /// </summary>
        /// <param name="PATH"></param>
        /// <param name="linhas"></param>
        public void RewriteCSV(string PATH, List<string> linhas)
        {
            using(StreamWriter output = new StreamWriter(PATH))
            {
                foreach (var item in linhas)
                {
                    output.Write(item + "\n");
                }
            }
        }
    }
}