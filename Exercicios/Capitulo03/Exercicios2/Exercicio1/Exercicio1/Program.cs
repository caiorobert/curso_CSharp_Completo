using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
        }
    }
}
