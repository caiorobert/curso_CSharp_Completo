using System;
using System.Globalization;

namespace Cap04
{
    class Program
    {

        

        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circuferencia = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circuferencia.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
