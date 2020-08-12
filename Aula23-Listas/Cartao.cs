

namespace Aula23
{
    public class Cartao
    {
        public string Titular { get; set; }
        public string Numero { get; set; }
        public string Bandeira { get; set; }

        public string Vencimento { get; set; }
        public string CVV { get; set; }

        public  Cartao(){

        }
        public Cartao(string titular , string numero , string bandeira , string vencimento , string cvv){
            this.Titular = titular;
            this.Numero = numero;
            this.Bandeira = bandeira;
            this.Vencimento = vencimento;
            this.CVV = cvv;
        }


    }
}