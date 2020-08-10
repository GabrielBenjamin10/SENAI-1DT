using System;

namespace Aula06Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
              CPF cpf = new CPF();
            cpf.nome = "Gabriel";
            System.Console.WriteLine( cpf.FazerSaudacao());

            cpf.cpf = "010.010.000-1";
            System.Console.WriteLine( cpf.ValidarCPF());
            System.Console.WriteLine( cpf.MostrarCPF());
        
        
        
        }
    }
}
