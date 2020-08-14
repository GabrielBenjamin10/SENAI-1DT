using System;

namespace Aula10Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Relatorio relatorio = new Relatorio();
            RelatorioMensal relatorioM = new RelatorioMensal();
            RelatorioAnual relatorioA = new RelatorioAnual();
            System.Console.WriteLine("Digite a data dos relatorios desejado no modelo : ANO/MÊS/DIA THORA:MINUTOS:SEGUNDOS");
            relatorio.data = DateTime.Parse(Console.ReadLine()); 
            System.Console.WriteLine("Data:" + relatorio.data);                            
            relatorio.MostrarRelatorio();
            relatorioM.MostrarRelatorio();
            relatorioA.MostrarRelatorio();
        }
    }
}
