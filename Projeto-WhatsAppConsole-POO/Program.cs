using System;
using System.Collections.Generic;
using System.Threading;

namespace ProjetoWppConsole
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Agenda Agenda = new Agenda();
            Contato c1 = new Contato("Gabriel" , "992663698");
            Contato c2 = new Contato("João" , "9928737789");
            

            /// Método que adiciona novos contatos ao csv da agenda
            //Agenda.Cadastrar(c1);
            //Agenda.Cadastrar(c2);
            // Excluindo o contato adicionada anteriormente
            //Agenda.Excluir("João");
            List<Contato> Lista = Agenda.Ler();
            System.Console.WriteLine("Lista de Contatos");
            foreach(Contato contatos in Lista){
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{contatos.Nome} -- {contatos.Telefone}");
                Console.ResetColor();
            }

            Thread.Sleep(4000);
            Console.Clear();

            Mensagem mensagem = new Mensagem();
            mensagem.Destinatario = c1;
            mensagem.Texto = "Olá , tudo bem?";
            System.Console.WriteLine(mensagem.Enviar()); 
             
            

            


           

            
        }
    }
}
