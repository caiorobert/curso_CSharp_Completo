using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, A, pi = 3.14159;
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A = pi * Math.Pow(R, 2.0);

            Console.WriteLine("A=" + A.ToString("f4", CultureInfo.InvariantCulture));
        }
    }
}
