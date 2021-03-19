using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double salarioHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = salarioHora * (double) horas;
            Console.WriteLine($"NUMBER = {numero}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
