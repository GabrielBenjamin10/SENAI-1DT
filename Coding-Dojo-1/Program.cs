using System;

namespace Aula18
{
    class Program
    {
        static void Main(string[] args)
        {                      
            Jogador ribamar = new Jogador();
            System.Console.WriteLine(ribamar.Nome);
            System.Console.WriteLine("Qual a posição do jogador? Atacante , Defensor ou Meio Campista");
            System.Console.WriteLine(ribamar.Posicao = Console.ReadLine());  
            System.Console.WriteLine(ribamar.Nascimento = DateTime.Parse("21/05/1997"));   
            Console.WriteLine(ribamar.CalcularIdade() );
            Console.WriteLine( ribamar.VerificarAposentadoria() );
            
            //isso, mas qual variavel vc quer criar? tem idade, nascimento, nacionalidade
            // tz certo assim kai , mas a gente criou idade com "I" maisculo, vcc pode dar um console writeline ai
            // assim viu kai, faz isso com mais uma variavel
            // é pra fazer o que vc fez ai em cima mas com nacionalidade e outras coisas
            // com oq vcs estão perdidos?

        }
    }
}
