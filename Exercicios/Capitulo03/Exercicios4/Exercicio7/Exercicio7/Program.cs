using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número e descubra seu valor ao quadrado e ao cubo. O resultado virá como:");
            Console.WriteLine("linha quadrado cubo");

            int numero = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numero; i++)
            {
                double quadrado = Math.Pow(i, 2.0);
                double cubo = Math.Pow(i, 3.0);
                Console.WriteLine($"{i} {quadrado} {cubo}");
            }
        }
    }
}
