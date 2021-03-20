using System;
using System.Globalization;

namespace Exercicio4_UsandoStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double qtdDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"Valor a ser pago em reais = {ConversorDeMoeda.ConversaoDolar(dolar, qtdDolar).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
