namespace Exercicio4_UsandoStatic
{
    class ConversorDeMoeda
    {
        static double Iof = 0.06;
        
        public static double ConversaoDolar(double dolar, double qtdDolar)
        {
            double reais = dolar * qtdDolar;
            return reais += reais * Iof;
        }
    }
}
