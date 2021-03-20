using System;
using System.Globalization;

namespace Cap04
{
    class Program
    {

        

        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circuferencia = calculadora.Circunferencia(raio);
            double volume = calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circuferencia.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
