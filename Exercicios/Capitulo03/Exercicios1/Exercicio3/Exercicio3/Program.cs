using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, Resultado;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            Resultado = (A * B - C * D);

            Console.WriteLine(Resultado);
        }
    }
}
