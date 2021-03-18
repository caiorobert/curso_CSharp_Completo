using System;
using System.Globalization;

namespace Cap03_ExercicioFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa:");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] vetor = Console.ReadLine().Split(" ");
            string seuNome = vetor[0];
            int suaIdade = int.Parse(vetor[1]);
            double suaAltura = double.Parse(vetor[2], CultureInfo.InvariantCulture);


            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(seuNome);
            Console.WriteLine(suaIdade);
            Console.WriteLine(suaAltura);
        }
    }
}
