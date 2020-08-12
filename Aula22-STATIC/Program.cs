using System;

namespace Aula22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão Dolares em Reais:\n" + ConversorReal.ConverterDolarReal(10f));
            Console.WriteLine("Conversão Reais em Dolares:\n"+ ConversorReal.ConverterRealDolar(1000f));
            Console.WriteLine("Conversão Reais em Euros:\n" + ConversorReal.ConverterRealEuro(1000f));
            Console.WriteLine("Conversão Euros em Reais:\n" + ConversorReal.ConverterEuroReal(10f));

        }
    }
}
