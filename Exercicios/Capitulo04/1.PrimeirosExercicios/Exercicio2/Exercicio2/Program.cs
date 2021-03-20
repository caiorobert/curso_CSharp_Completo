using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1, funcionario2;
            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            double salarioMedio = 0.00;

            Console.WriteLine("Dados do primeiro funcionário:");

            Console.Write("Nome:");
            funcionario1.Nome = Console.ReadLine();

            Console.Write("Salário:");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Dados do segundo funcionário:");

            Console.Write("Nome:");
            funcionario2.Nome = Console.ReadLine();

            Console.Write("Salário:");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioMedio = (funcionario1.Salario + funcionario2.Salario) / 2.0;

            Console.Write($"Salário médio = {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
