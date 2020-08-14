namespace ProjetoWppConsole
{
    public class Mensagem
    {
        public string Texto { get; set;}
        public Contato Destinatario { get; set;}

        public string Enviar()
        {
            return $"Destinatário: {Destinatario.Nome} \n Mensagem: {Texto}";
        }
    }
}