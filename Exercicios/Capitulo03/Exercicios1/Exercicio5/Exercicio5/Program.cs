using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peca1, peca2;

            peca1 = Console.ReadLine().Split(" ");
            peca2 = Console.ReadLine().Split(" ");

            int qtd1 = int.Parse(peca1[1]);
            int qtd2 = int.Parse(peca2[1]);

            double valor1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);
            double valor2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double resultado = (qtd1 * valor1) + (qtd2 * valor2);

            Console.WriteLine($"VALOR A PAGAR: R$ {resultado.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
