namespace Aula22
{
    public static class ConversorReal
    {
        public static float ValorDolarRS = 5.26f;
        public static float ValorEuroRS = 5.93f;

        public static float ConverterRealDolar(float Real){
            return Real/ValorDolarRS;
        }

        public static float ConverterDolarReal(float Dolar){
            return Dolar * ValorDolarRS;
        }

        public static float ConverterRealEuro(float Real){
            return Real/ValorEuroRS;
        }

        public static float ConverterEuroReal(float euro){
            return euro * ValorEuroRS ;
        }

    }
}