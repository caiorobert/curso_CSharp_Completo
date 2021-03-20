using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro e descubra seus divisores:");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
