namespace Aula10Polimorfismo
{
    public class RelatorioAnual : Relatorio
    {
        public override void MostrarRelatorio(){
            ///base.MostrarRelatorio(): Achei que não faria sentido nesse problema adicionar o base nas classes filhas
            System.Console.WriteLine("Mostrando Relatorio por ano");
        }
    }
}