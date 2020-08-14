using System;

namespace Aula10Polimorfismo
{
    public class Relatorio
    {   
        public DateTime data;
        public virtual void MostrarRelatorio(){
            System.Console.WriteLine("Mostrando Relatório Geral");
        }
    }
}