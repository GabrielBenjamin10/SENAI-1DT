using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjetoWppConsole
{
    public class Agenda : IAgenda
    {
        
        private const string PATH = "Database/contatos.csv";

        public Agenda(){
            
            string directory = PATH.Split('/')[0];

            if(!Directory.Exists(directory)){
                Directory.CreateDirectory(directory);
            }

            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
        //Cadastrar Contato
        /// <summary>
        /// Definimos como os contatos serão salvos em nosso arquivo PATH.csv
        /// </summary>
        /// <param name="contato"></param>
        public void Cadastrar(Contato contato)
        {
            var linha = new string []{organizarContatoCSV(contato)};
            File.AppendAllLines(PATH,linha);
        }

        private string organizarContatoCSV(Contato c){
            return $"Nome:{c.Nome};Número:{c.Telefone} ";
        }
        //Fim do cadastro de contato


        // Inicio da exclusão de contatos

        /// <summary>
        /// Procuramos por algum contato e exluimos
        /// </summary>
        /// <param name="contato">Parametro que indica o contato que será excluido</param>
        public void Excluir(string contato)
        {
            List<string> ContatosB = new List<string>();
            using(StreamReader contacts = new StreamReader(PATH))
            {
                string linha;
                while((linha = contacts.ReadLine()) != null)
                {
                    ContatosB.Add(linha);
                }
            }

            // Removemos o que o contato indicado "conter"
            ContatosB.RemoveAll(c => c.Contains(contato));
            //Reescrevemos nosso CSV com nossa nova lista
            ReescreverCSV(ContatosB);
        }

        /// <summary>
        /// Metódo de auxilio para exclusão , onde reescremos nosso CSV do zero
        /// </summary>
        /// <param name="ctts"></param>
        private void ReescreverCSV(List<string> ctts)
        {
            using(StreamWriter saida = new StreamWriter(PATH))
            {
                foreach(string cts in ctts)
                {
                    saida.Write(cts + "\n");
                }
         
            }
        }

     //Fim da exclusão de contatos


        // Inicio da Leitura dos dados
        public List<Contato> Ler()
        {   
            //Lista de retorno
            List<Contato> Contatos = new List<Contato>();

            // Nesse array de strings, ordenamos que o programa leia e armazene no array, todo o conteúdo inserido em PATH
            string [] linhas = File.ReadAllLines(PATH); 

            foreach (string linha in linhas)
            {
                //Primeiro tratamento de dados, quebramos o bloco com ";"
                //  indice[0]     indice[1]
                //Nome:{c.Nome};Número:{c.Telefone}

                string [] dados = linha.Split(";");

                //   0    (1)          1   (1)   
                //Nome:{c.Nome};Número:{c.Telefone}
                Contato contato = new Contato(SepararDados(dados[0]) , SepararDados(dados[1]));
                //Adicionamos à leitura o contato após o tratamento em splits
                Contatos.Add(contato);
            }
            Contatos = Contatos.OrderBy(c => c.Nome).ToList();
            return Contatos ;
        }

        /// <summary>
        /// Metodo auxiliar para quebrar o bloco novamente em uma nova Split
        /// </summary>
        /// <param name="coluna"></param>
        /// <returns></returns>
        private string SepararDados(string coluna){
            //   0        1 
            // Contato:Gabriel
            return coluna.Split(":")[1]; 
        }

        //Final da leitura de dados
    }
}