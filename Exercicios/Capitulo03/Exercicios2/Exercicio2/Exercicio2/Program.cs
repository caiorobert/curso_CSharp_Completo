using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            if(numero == 0)
            {
                Console.WriteLine("NEUTRO");
            }
            else if(numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
