using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha:");
            int senha = 2002;

            int senhaEntrada = int.Parse(Console.ReadLine());

            while(senhaEntrada != senha)
            {
                Console.WriteLine("Senha inválida");
                senhaEntrada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
