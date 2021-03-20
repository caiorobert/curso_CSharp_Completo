using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de divisões que deseja fazer: ");

            int q = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite os números para a divisão, o primeiro será divido pelo segundo: ");

            for (int i = 1; i <= q; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                int n1 = int.Parse(numeros[0]);
                int n2 = int.Parse(numeros[1]);

                if (n2 == 0)
                {
                    Console.WriteLine("Divisão impossível!");
                }
                else
                {
                    double resultado = (double)n1 / n2;
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
